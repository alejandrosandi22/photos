using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Fotos
{
    public partial class formFotos : Form
    {
        public formFotos()
        {
            InitializeComponent();
        }

        ////////////////////////Varibles////////////////////////
        string filepath = null;
        bool boolMover = false;

        Point inicial;
        Image imgOriginal;
        int intTB = 0;

        string strDireccion = "";
        string strRuta = "";

        bool boolMove = false;
        int intX = 0;
        int intY = 0;

        Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        public formFotos(string[] file)
        {
            InitializeComponent();
            if (file.Length != 0)
            {
                filepath = file[0];
            }
        }

        private void formFotos_Load(object sender, EventArgs e)
        {
            //Bordes y barra de título del formulario\\
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            //Mover el picturebox con el mouse\\
            Controls.OfType<Control>().Where(ctr => ctr is PictureBox).ToList().ForEach(ctr =>
            {
                ctr.MouseDown += Ctr_MouseDown;
                ctr.MouseUp += Ctr_MouseUp;
                ctr.MouseMove += Ctr_MouseMove;
            });

            //Cargar una imagen de donde se escoge en el explorador de archivos\\
            //Condición si se escogen una imagen\\
            if (filepath != null)
            {
                //Carga la imagen desde la ruta de la imagen en el picturebox\\
                pbImagen.ImageLocation = filepath;
                trackBar1.Value = 0; //Da valor de 0 al trackbar\\

                //Se crea la variable tipo char[] con el nombre delimitador, donde se da el valor de "\" para separar las
                //rutas. (C:\Imagenes\foto.jpg - C: Imagenes fotos.jpg)\\
                char[] charDelimitador = { '\\' };
                //S ecra la variable tipo string[] con el nombre strURL, donde la ruta de la imagen seleccionada (filepath)
                //se separa con la función split entre cada "\"\\
                string[] strURL = filepath.Split(charDelimitador);

                string strSafeName = "";//Se crea la vaiable tipo cadena con el nombre strSafeName\\
                int z;//Se crea la vaiable tipo entero con el nombre z\\

                //Se crea un bucle for donde se guarda solo el nombre del archivo\\
                for (z = 0; z < strURL.Length; z++)
                {
                    strSafeName = strURL[z];//Se guarda el nombre del archivo en la variable strName\\
                }

                int i;//Se crea la vaiable tipo entero con el nombre i\\
                //Se crea un bucle for donde se crea la ruta al directorio sin el nombre del archivo\\
                for (i = 0; i < strURL.Length - 1; i++)
                {
                    strRuta = strRuta + strURL[i] + "\\";//Se guarda en la variable strRuta la ruta al directorio\\
                }

                //Se establece la variable como un nuevo directorio\\
                DirectoryInfo diDirectorio = new DirectoryInfo(strRuta);
                //Se obtienen los archivos con las extensiones mencionadas\\
                var varFiles = diDirectorio.GetFiles().Where(a => (a.Extension.Equals(".jpg") || a.Extension.Equals(".JPE") || a.Extension.Equals(".jpeg") || a.Extension.Equals(".JFI") || a.Extension.Equals(".JFIF") || a.Extension.Equals(".png") || a.Extension.Equals(".bmp") || a.Extension.Equals(".RAW") || a.Extension.Equals(".tiff") || a.Extension.Equals(".ico") || a.Extension.Equals(".gif")));

                pbImagen.ImageLocation = filepath;//Cargar la imagen dentro del picturebox\\
                lblArchivo.Text = strSafeName;//Carga el nombre del archivo en el label\\

                //Busca las imagenes en el directorio para agregarlas al listbox\\
                foreach (var varArchivo in varFiles)
                {
                    lbImagenes.Items.Add(varArchivo);//Agrega las imagenes del directorio en el listbox\\
                }

                //Bucle while para posicionarse en el nombre del archivo actual\\
                while (!(lbImagenes.Text == lblArchivo.Text))
                {
                    lbImagenes.SelectedIndex++;//Aumenta más 1 para posisionarse en el nombre del archivo\\
                }

                lbImagenes_SelectedIndexChanged(sender, e);
                imgOriginal = pbImagen.Image;//Guarda la imagen del picturebox dentro de la variable imgOriginal\\
            }    
        }

        private void pbImagen_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            while (pbImagen.Width < pbImagen.Image.Width || pbImagen.Height < pbImagen.Image.Height)
            {
                trackBar1.Value = trackBar1.Value - 5;
                pbImagen.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
            }
            intTB = trackBar1.Value;//Se guarda el valor actual del trackbar1\\
            trackBar1.Value = intTB;
            pbImagen.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
        }

        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;
            if (boolMover)
            {
                ctr.Left = e.X + ctr.Left - inicial.X;
                ctr.Top = e.Y + ctr.Top - inicial.Y;
                ibAjustar.IconChar = IconChar.ExpandArrowsAlt;
            }
        }

        private void Ctr_MouseUp(object sender, MouseEventArgs e) => boolMover = false;

        private void Ctr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                boolMover = true;
                inicial = e.Location;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPantalla_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnPantalla.BackgroundImage = Properties.Resources.minimizar_pantalla;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnPantalla.BackgroundImage = Properties.Resources.maximizar_pantalla;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            boolMove = true;
            intX = e.X;
            intY = e.Y;
        }

        private void pnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (boolMove)
            {
                Point pxy = PointToScreen(e.Location);
                Location = new Point(pxy.X - intX, pxy.Y - intY);
            }
        }

        private void pnlBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            boolMove = false;
        }

        ////////////////////////////////////////////////
        ////////////////Cargar imagenes/////////////////
        ////////////////////////////////////////////////
        private void ibAbrir_Click(object sender, EventArgs e)
        {
            lbImagenes.Items.Clear();//Elimina los archivos del listbox\\
            strRuta = "";//Inicializa la variable strRuta en 0\\

            //Abre un open file dialog para importar la imagen\\
            OpenFileDialog ofdImagen = new OpenFileDialog();
            //Se establece el tipo de extensión de imagenes que se permiten abrir\\
            ofdImagen.Filter = "Archivos de imagen |*.jpg; ;*.JPE; *.jpeg; *.JFI; *.JFIF; *.png; *.bmp; *.RAW; *.tiff; *.ico; *.gif";
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                string url = ofdImagen.FileName;
                //Se crea la variable tipo char[] con el nombre delimitador, donde se da el valor de "\" para separar las
                //rutas. (C:\Imagenes\foto.jpg - C: Imagenes fotos.jpg)\\
                char[] delimitador = { '\\' };
                //S ecra la variable tipo string[] con el nombre strURL, donde la ruta de la imagen seleccionada (filepath)
                //se separa con la función split entre cada "\"\\
                string[] strURL = url.Split(delimitador);

                int i;//Se crea la vaiable tipo entero con el nombre i\\
                //Se crea un bucle for donde se crea la ruta al directorio sin el nombre del archivo\\
                for (i = 0; i < strURL.Length - 1; i++)
                {
                    strRuta = strRuta + strURL[i] + "\\";//Se guarda en la variable strRuta la ruta al directorio\\
                }

                //Se establece la variable como un nuevo directorio\\
                DirectoryInfo difo = new DirectoryInfo(strRuta);
                //Se obtienen los archivos con las extensiones mencionadas\\
                var files = difo.GetFiles().Where(a => (a.Extension.Equals(".jpg") || a.Extension.Equals(".JPE") || a.Extension.Equals(".jpeg") || a.Extension.Equals(".JFI") || a.Extension.Equals(".JFIF") || a.Extension.Equals(".png") || a.Extension.Equals(".bmp") || a.Extension.Equals(".RAW") || a.Extension.Equals(".tiff") || a.Extension.Equals(".ico") || a.Extension.Equals(".gif")));


                strDireccion = ofdImagen.FileName;
                lblArchivo.Text = ofdImagen.SafeFileName;
                pbImagen.Load(strDireccion);

                foreach (var archivo in files)
                {
                    lbImagenes.Items.Add(archivo);
                }
                imgOriginal = pbImagen.Image;

                string str = lblArchivo.Text;
                while (!(lbImagenes.Text == str))
                {
                    lbImagenes.SelectedIndex++;
                }

                trackBar1.Value = 0;
                while (pbImagen.Width < pbImagen.Image.Width || pbImagen.Height < pbImagen.Image.Height)
                {
                    trackBar1.Value = trackBar1.Value - 5;
                    pbImagen.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
                }

                intTB = trackBar1.Value;

            }

        }

        private void lbImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var varSelected = lbImagenes.SelectedItems[0].ToString();

                if (!string.IsNullOrEmpty(varSelected) && !string.IsNullOrEmpty(strRuta))
                {
                    var fullpath = Path.Combine(strRuta, varSelected);
                    pbImagen.Image = Image.FromFile(fullpath);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK);
            }
        }

        private void ibIzquierda_Click(object sender, EventArgs e)
        {
            if (lbImagenes.SelectedIndex == 0)
            {
                lbImagenes.SelectedIndex = lbImagenes.Items.Count - 1;
            }
            else
            {
                lbImagenes.SelectedIndex--;
                lblArchivo.Text = lbImagenes.SelectedItem.ToString();
            }
            lbImagenes_SelectedIndexChanged(sender, e);
            imgOriginal = pbImagen.Image;
            trackBar1.Value = 0;

            while (pbImagen.Width < pbImagen.Image.Width || pbImagen.Height < pbImagen.Image.Height)
            {
                trackBar1.Value = trackBar1.Value - 5;
                pbImagen.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
            }
            intTB = trackBar1.Value;
        }

        private void ibDerecha_Click(object sender, EventArgs e)
        {
            if (lbImagenes.SelectedIndex == lbImagenes.Items.Count - 1)
            {
                lbImagenes.SelectedIndex = 0;
            }
            else
            {
                lbImagenes.SelectedIndex++;
                lblArchivo.Text = lbImagenes.SelectedItem.ToString();
            }
            lbImagenes_SelectedIndexChanged(sender, e);
            imgOriginal = pbImagen.Image;
            trackBar1.Value = 0;

            while (pbImagen.Width < pbImagen.Image.Width || pbImagen.Height < pbImagen.Image.Height)
            {
                trackBar1.Value = trackBar1.Value - 5;
                pbImagen.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
            }
            intTB = trackBar1.Value;
        }

        private void ibGirar_Click(object sender, EventArgs e)
        {
            pbImagen.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbImagen.Refresh();
        }

        private void ibAjustar_Click(object sender, EventArgs e)
        {
            ibAjustar.IconChar = IconChar.CompressArrowsAlt;
            pbImagen.Location = new Point(0, 81);

            trackBar1.Value = intTB;
            pbImagen.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));


        }

        ///////////////////////////////////////////////////
        ////////////////Tamaño de imagenes/////////////////
        /////////////////////////////////////////////////


        ////////////////////////Botón más////////////////////////
        private void ibMas_Click(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = trackBar1.Value + 5;
                pbImagen.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
                ibAjustar.IconChar = IconChar.ExpandArrowsAlt;
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede aumentar más el tamaño", "Error", MessageBoxButtons.OK);
            }

        }

        ////////////////////////Botón menos////////////////////////
        private void ibMenos_Click(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = trackBar1.Value - 5;
                pbImagen.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
                ibAjustar.IconChar = IconChar.ExpandArrowsAlt;
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede disminuir más el tamaño", "Error", MessageBoxButtons.OK);
            }
        }

        /////////////////////////////////////////////////
        /////////////////////Botones/////////////////////
        /////////////////////////////////////////////////

        ////////////////////////Botón abrir////////////////////////
        private void ibAbrir_MouseHover(object sender, EventArgs e)
        {
            ibAbrir.IconColor = Color.FromArgb(255, 165, 179, 193);
        }

        private void ibAbrir_MouseLeave(object sender, EventArgs e)
        {
            ibAbrir.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void ibAbrir_MouseDown(object sender, MouseEventArgs e)
        {
            ibAbrir.IconColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void ibAbrir_MouseUp(object sender, MouseEventArgs e)
        {
            ibAbrir.IconColor = Color.FromArgb(255, 255, 255, 255);
        }


        ////////////////////////Botón más////////////////////////

        private void ibMas_MouseHover(object sender, EventArgs e)
        {
            ibMas.IconColor = Color.FromArgb(255, 165, 179, 193);
        }

        private void ibMas_MouseLeave(object sender, EventArgs e)
        {
            ibMas.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void ibMas_MouseDown(object sender, MouseEventArgs e)
        {
            ibMas.IconColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void ibMas_MouseUp(object sender, MouseEventArgs e)
        {
            ibMas.IconColor = Color.FromArgb(255, 255, 255, 255);
        }
        ////////////////////////Botón izquierda////////////////////////
        private void ibIzquierda_MouseHover(object sender, EventArgs e)
        {
            ibIzquierda.IconColor = Color.FromArgb(255, 165, 179, 193);
        }

        private void ibIzquierda_MouseLeave(object sender, EventArgs e)
        {
            ibIzquierda.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void ibIzquierda_MouseDown(object sender, MouseEventArgs e)
        {
            ibIzquierda.IconColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void ibIzquierda_MouseUp(object sender, MouseEventArgs e)
        {
            ibIzquierda.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        ////////////////////////Botón derecha////////////////////////
        private void ibDerecha_MouseHover(object sender, EventArgs e)
        {
            ibDerecha.IconColor = Color.FromArgb(255, 165, 179, 193);
        }

        private void ibDerecha_MouseLeave(object sender, EventArgs e)
        {
            ibDerecha.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void ibDerecha_MouseDown(object sender, MouseEventArgs e)
        {
            ibDerecha.IconColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void ibDerecha_MouseUp(object sender, MouseEventArgs e)
        {
            ibDerecha.IconColor = Color.FromArgb(255, 255, 255, 255);
        }


        ////////////////////////Botón menos////////////////////////

        private void ibMenos_MouseHover(object sender, EventArgs e)
        {
            ibMenos.IconColor = Color.FromArgb(255, 165, 179, 193);
        }

        private void ibMenos_MouseLeave(object sender, EventArgs e)
        {
            ibMenos.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void ibMenos_MouseDown(object sender, MouseEventArgs e)
        {
            ibMenos.IconColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void ibMenos_MouseUp(object sender, MouseEventArgs e)
        {
            ibMenos.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        ////////////////////////Botón ajustar////////////////////////
        private void ibAjustar_MouseHover(object sender, EventArgs e)
        {
            ibAjustar.IconColor = Color.FromArgb(255, 165, 179, 193);
        }

        private void ibAjustar_MouseLeave(object sender, EventArgs e)
        {
            ibAjustar.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void ibAjustar_MouseDown(object sender, MouseEventArgs e)
        {
            ibAjustar.IconColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void ibAjustar_MouseUp(object sender, MouseEventArgs e)
        {
            ibAjustar.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        ////////////////////////Botón girar////////////////////////

        private void ibGirar_MouseHover(object sender, EventArgs e)
        {
            ibGirar.IconColor = Color.FromArgb(255, 165, 179, 193);
        }

        private void ibGirar_MouseLeave(object sender, EventArgs e)
        {
            ibGirar.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void ibGirar_MouseDown(object sender, MouseEventArgs e)
        {
            ibGirar.IconColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void ibGirar_MouseUp(object sender, MouseEventArgs e)
        {
            ibGirar.IconColor = Color.FromArgb(255, 255, 255, 255);
        }

        ////////////////////////Botón ingresar////////////////////////
        private void ibIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Habilitado en próximas versiones", "Inhabilitado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}