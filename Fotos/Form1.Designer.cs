
namespace Fotos
{
    partial class formFotos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFotos));
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btnPantalla = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlHerramientas = new System.Windows.Forms.Panel();
            this.ibGirar = new FontAwesome.Sharp.IconButton();
            this.ibDerecha = new FontAwesome.Sharp.IconButton();
            this.ibIngresar = new FontAwesome.Sharp.IconButton();
            this.ibIzquierda = new FontAwesome.Sharp.IconButton();
            this.ibAbrir = new FontAwesome.Sharp.IconButton();
            this.ibAjustar = new FontAwesome.Sharp.IconButton();
            this.ibMenos = new FontAwesome.Sharp.IconButton();
            this.ibMas = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lbImagenes = new System.Windows.Forms.ListBox();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.pnlBarraTitulo.Controls.Add(this.trackBar1);
            this.pnlBarraTitulo.Controls.Add(this.pictureBox1);
            this.pnlBarraTitulo.Controls.Add(this.lblArchivo);
            this.pnlBarraTitulo.Controls.Add(this.btnPantalla);
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(883, 33);
            this.pnlBarraTitulo.TabIndex = 0;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            this.pnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
            this.pnlBarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(311, 0);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(303, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Fotos.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.ForeColor = System.Drawing.Color.White;
            this.lblArchivo.Location = new System.Drawing.Point(42, 9);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(110, 15);
            this.lblArchivo.TabIndex = 3;
            this.lblArchivo.Text = "soxtware_fotos.jpg";
            // 
            // btnPantalla
            // 
            this.btnPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPantalla.BackgroundImage = global::Fotos.Properties.Resources.maximizar_pantalla;
            this.btnPantalla.FlatAppearance.BorderSize = 0;
            this.btnPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantalla.Location = new System.Drawing.Point(791, 0);
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Size = new System.Drawing.Size(46, 33);
            this.btnPantalla.TabIndex = 2;
            this.btnPantalla.UseVisualStyleBackColor = true;
            this.btnPantalla.Click += new System.EventHandler(this.btnPantalla_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Fotos.Properties.Resources.cerrar;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(837, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(46, 33);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlHerramientas
            // 
            this.pnlHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.pnlHerramientas.Controls.Add(this.ibGirar);
            this.pnlHerramientas.Controls.Add(this.ibDerecha);
            this.pnlHerramientas.Controls.Add(this.ibIngresar);
            this.pnlHerramientas.Controls.Add(this.ibIzquierda);
            this.pnlHerramientas.Controls.Add(this.ibAbrir);
            this.pnlHerramientas.Controls.Add(this.ibAjustar);
            this.pnlHerramientas.Controls.Add(this.ibMenos);
            this.pnlHerramientas.Controls.Add(this.ibMas);
            this.pnlHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHerramientas.Location = new System.Drawing.Point(0, 33);
            this.pnlHerramientas.Name = "pnlHerramientas";
            this.pnlHerramientas.Size = new System.Drawing.Size(883, 47);
            this.pnlHerramientas.TabIndex = 1;
            // 
            // ibGirar
            // 
            this.ibGirar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ibGirar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibGirar.FlatAppearance.BorderSize = 0;
            this.ibGirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibGirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibGirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibGirar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibGirar.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.ibGirar.IconColor = System.Drawing.Color.White;
            this.ibGirar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibGirar.IconSize = 30;
            this.ibGirar.Location = new System.Drawing.Point(524, 7);
            this.ibGirar.Name = "ibGirar";
            this.ibGirar.Size = new System.Drawing.Size(30, 30);
            this.ibGirar.TabIndex = 8;
            this.ibGirar.UseVisualStyleBackColor = true;
            this.ibGirar.Click += new System.EventHandler(this.ibGirar_Click);
            this.ibGirar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibGirar_MouseDown);
            this.ibGirar.MouseLeave += new System.EventHandler(this.ibGirar_MouseLeave);
            this.ibGirar.MouseHover += new System.EventHandler(this.ibGirar_MouseHover);
            this.ibGirar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibGirar_MouseUp);
            // 
            // ibDerecha
            // 
            this.ibDerecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ibDerecha.BackColor = System.Drawing.Color.Transparent;
            this.ibDerecha.FlatAppearance.BorderSize = 0;
            this.ibDerecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ibDerecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ibDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDerecha.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.ibDerecha.IconColor = System.Drawing.Color.White;
            this.ibDerecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDerecha.IconSize = 30;
            this.ibDerecha.Location = new System.Drawing.Point(311, 7);
            this.ibDerecha.Name = "ibDerecha";
            this.ibDerecha.Size = new System.Drawing.Size(30, 30);
            this.ibDerecha.TabIndex = 5;
            this.ibDerecha.UseVisualStyleBackColor = false;
            this.ibDerecha.Click += new System.EventHandler(this.ibDerecha_Click);
            this.ibDerecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibDerecha_MouseDown);
            this.ibDerecha.MouseLeave += new System.EventHandler(this.ibDerecha_MouseLeave);
            this.ibDerecha.MouseHover += new System.EventHandler(this.ibDerecha_MouseHover);
            this.ibDerecha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibDerecha_MouseUp);
            // 
            // ibIngresar
            // 
            this.ibIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibIngresar.FlatAppearance.BorderSize = 0;
            this.ibIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibIngresar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibIngresar.ForeColor = System.Drawing.Color.White;
            this.ibIngresar.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.ibIngresar.IconColor = System.Drawing.Color.White;
            this.ibIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibIngresar.IconSize = 33;
            this.ibIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibIngresar.Location = new System.Drawing.Point(701, 2);
            this.ibIngresar.Name = "ibIngresar";
            this.ibIngresar.Size = new System.Drawing.Size(179, 41);
            this.ibIngresar.TabIndex = 7;
            this.ibIngresar.Text = "Iniciar Sesión o Registarse";
            this.ibIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibIngresar.UseVisualStyleBackColor = false;
            this.ibIngresar.Click += new System.EventHandler(this.ibIngresar_Click);
            // 
            // ibIzquierda
            // 
            this.ibIzquierda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ibIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.ibIzquierda.FlatAppearance.BorderSize = 0;
            this.ibIzquierda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ibIzquierda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ibIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibIzquierda.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.ibIzquierda.IconColor = System.Drawing.Color.White;
            this.ibIzquierda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibIzquierda.IconSize = 30;
            this.ibIzquierda.Location = new System.Drawing.Point(275, 7);
            this.ibIzquierda.Name = "ibIzquierda";
            this.ibIzquierda.Size = new System.Drawing.Size(30, 30);
            this.ibIzquierda.TabIndex = 4;
            this.ibIzquierda.UseVisualStyleBackColor = false;
            this.ibIzquierda.Click += new System.EventHandler(this.ibIzquierda_Click);
            this.ibIzquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibIzquierda_MouseDown);
            this.ibIzquierda.MouseLeave += new System.EventHandler(this.ibIzquierda_MouseLeave);
            this.ibIzquierda.MouseHover += new System.EventHandler(this.ibIzquierda_MouseHover);
            this.ibIzquierda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibIzquierda_MouseUp);
            // 
            // ibAbrir
            // 
            this.ibAbrir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ibAbrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibAbrir.FlatAppearance.BorderSize = 0;
            this.ibAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAbrir.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.ibAbrir.IconColor = System.Drawing.Color.White;
            this.ibAbrir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAbrir.IconSize = 30;
            this.ibAbrir.Location = new System.Drawing.Point(347, 7);
            this.ibAbrir.Name = "ibAbrir";
            this.ibAbrir.Size = new System.Drawing.Size(30, 30);
            this.ibAbrir.TabIndex = 5;
            this.ibAbrir.UseVisualStyleBackColor = true;
            this.ibAbrir.Click += new System.EventHandler(this.ibAbrir_Click);
            this.ibAbrir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibAbrir_MouseDown);
            this.ibAbrir.MouseLeave += new System.EventHandler(this.ibAbrir_MouseLeave);
            this.ibAbrir.MouseHover += new System.EventHandler(this.ibAbrir_MouseHover);
            this.ibAbrir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibAbrir_MouseUp);
            // 
            // ibAjustar
            // 
            this.ibAjustar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ibAjustar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibAjustar.FlatAppearance.BorderSize = 0;
            this.ibAjustar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibAjustar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibAjustar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAjustar.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.ibAjustar.IconColor = System.Drawing.Color.White;
            this.ibAjustar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAjustar.IconSize = 30;
            this.ibAjustar.Location = new System.Drawing.Point(485, 7);
            this.ibAjustar.Name = "ibAjustar";
            this.ibAjustar.Size = new System.Drawing.Size(30, 30);
            this.ibAjustar.TabIndex = 6;
            this.ibAjustar.UseVisualStyleBackColor = true;
            this.ibAjustar.Click += new System.EventHandler(this.ibAjustar_Click);
            this.ibAjustar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibAjustar_MouseDown);
            this.ibAjustar.MouseLeave += new System.EventHandler(this.ibAjustar_MouseLeave);
            this.ibAjustar.MouseHover += new System.EventHandler(this.ibAjustar_MouseHover);
            this.ibAjustar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibAjustar_MouseUp);
            // 
            // ibMenos
            // 
            this.ibMenos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ibMenos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibMenos.FlatAppearance.BorderSize = 0;
            this.ibMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibMenos.IconChar = FontAwesome.Sharp.IconChar.SearchMinus;
            this.ibMenos.IconColor = System.Drawing.Color.White;
            this.ibMenos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibMenos.IconSize = 30;
            this.ibMenos.Location = new System.Drawing.Point(439, 7);
            this.ibMenos.Name = "ibMenos";
            this.ibMenos.Size = new System.Drawing.Size(30, 30);
            this.ibMenos.TabIndex = 5;
            this.ibMenos.UseVisualStyleBackColor = true;
            this.ibMenos.Click += new System.EventHandler(this.ibMenos_Click);
            this.ibMenos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibMenos_MouseDown);
            this.ibMenos.MouseLeave += new System.EventHandler(this.ibMenos_MouseLeave);
            this.ibMenos.MouseHover += new System.EventHandler(this.ibMenos_MouseHover);
            this.ibMenos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibMenos_MouseUp);
            // 
            // ibMas
            // 
            this.ibMas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ibMas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibMas.FlatAppearance.BorderSize = 0;
            this.ibMas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibMas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ibMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibMas.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.ibMas.IconColor = System.Drawing.Color.White;
            this.ibMas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibMas.IconSize = 30;
            this.ibMas.Location = new System.Drawing.Point(393, 7);
            this.ibMas.Name = "ibMas";
            this.ibMas.Size = new System.Drawing.Size(30, 30);
            this.ibMas.TabIndex = 4;
            this.ibMas.UseVisualStyleBackColor = true;
            this.ibMas.Click += new System.EventHandler(this.ibMas_Click);
            this.ibMas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ibMas_MouseDown);
            this.ibMas.MouseLeave += new System.EventHandler(this.ibMas_MouseLeave);
            this.ibMas.MouseHover += new System.EventHandler(this.ibMas_MouseHover);
            this.ibMas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ibMas_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btnMinimizar.BackgroundImage = global::Fotos.Properties.Resources.minimizar;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(745, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(46, 33);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.Location = new System.Drawing.Point(0, 81);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(883, 480);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 6;
            this.pbImagen.TabStop = false;
            this.pbImagen.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbImagen_LoadCompleted);
            // 
            // lbImagenes
            // 
            this.lbImagenes.FormattingEnabled = true;
            this.lbImagenes.Location = new System.Drawing.Point(-200, -200);
            this.lbImagenes.Name = "lbImagenes";
            this.lbImagenes.Size = new System.Drawing.Size(200, 199);
            this.lbImagenes.TabIndex = 7;
            this.lbImagenes.SelectedIndexChanged += new System.EventHandler(this.lbImagenes_SelectedIndexChanged);
            // 
            // formFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 561);
            this.Controls.Add(this.lbImagenes);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.pnlHerramientas);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pbImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(623, 350);
            this.Name = "formFotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotos";
            this.Load += new System.EventHandler(this.formFotos_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHerramientas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlHerramientas;
        private System.Windows.Forms.Button btnPantalla;
        private System.Windows.Forms.Button btnMinimizar;
        private FontAwesome.Sharp.IconButton ibMas;
        private FontAwesome.Sharp.IconButton ibAjustar;
        private FontAwesome.Sharp.IconButton ibMenos;
        private FontAwesome.Sharp.IconButton ibAbrir;
        private FontAwesome.Sharp.IconButton ibIzquierda;
        private FontAwesome.Sharp.IconButton ibDerecha;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.PictureBox pbImagen;
        private FontAwesome.Sharp.IconButton ibIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbImagenes;
        private FontAwesome.Sharp.IconButton ibGirar;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

