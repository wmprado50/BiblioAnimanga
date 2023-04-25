namespace BibliotecaAnimanga
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnAnimes = new System.Windows.Forms.Button();
            this.panelSubMenuAnime = new System.Windows.Forms.Panel();
            this.btnMangas = new System.Windows.Forms.Button();
            this.panelSubMenuManga = new System.Windows.Forms.Panel();
            this.btnRegistrarAnime = new System.Windows.Forms.Button();
            this.btnRegistrarGeneroA = new System.Windows.Forms.Button();
            this.btnRegistrarEstudio = new System.Windows.Forms.Button();
            this.btnBuscarAnimes = new System.Windows.Forms.Button();
            this.btnRegistrarManga = new System.Windows.Forms.Button();
            this.btnRegistrarGeneroM = new System.Windows.Forms.Button();
            this.btnRegistrarAutor = new System.Windows.Forms.Button();
            this.btnRegistrarIlus = new System.Windows.Forms.Button();
            this.btnBuscarMangas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panelSubMenuUsuarios = new System.Windows.Forms.Panel();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSubMenuAnime.SuspendLayout();
            this.panelSubMenuManga.SuspendLayout();
            this.panelSubMenuUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoScroll = true;
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.MenuVertical.Controls.Add(this.panelSubMenuUsuarios);
            this.MenuVertical.Controls.Add(this.btnUsuarios);
            this.MenuVertical.Controls.Add(this.panelSubMenuManga);
            this.MenuVertical.Controls.Add(this.btnMangas);
            this.MenuVertical.Controls.Add(this.panelSubMenuAnime);
            this.MenuVertical.Controls.Add(this.btnAnimes);
            this.MenuVertical.Controls.Add(this.btnMenuPrincipal);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btnSalir);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(211, 650);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 711);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 62);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(211, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(789, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = global::BibliotecaAnimanga.Properties.Resources._8666820_minus_delete_remove_icon;
            this.iconminimizar.Location = new System.Drawing.Point(675, 12);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(33, 31);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 4;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = global::BibliotecaAnimanga.Properties.Resources._8679951_close_fill_icon;
            this.iconcerrar.Location = new System.Drawing.Point(752, 12);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(33, 31);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 3;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = global::BibliotecaAnimanga.Properties.Resources._8675794_ic_fluent_window_regular_icon;
            this.iconmaximizar.Location = new System.Drawing.Point(714, 12);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(33, 31);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 2;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = global::BibliotecaAnimanga.Properties.Resources._8675275_ic_fluent_slide_multiple_regular_icon;
            this.iconrestaurar.Location = new System.Drawing.Point(714, 12);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(33, 31);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 1;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 100);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMenuPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(0, 100);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(194, 62);
            this.btnMenuPrincipal.TabIndex = 9;
            this.btnMenuPrincipal.Text = "Menú Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnAnimes
            // 
            this.btnAnimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnimes.FlatAppearance.BorderSize = 0;
            this.btnAnimes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAnimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnimes.Image = ((System.Drawing.Image)(resources.GetObject("btnAnimes.Image")));
            this.btnAnimes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimes.Location = new System.Drawing.Point(0, 162);
            this.btnAnimes.Name = "btnAnimes";
            this.btnAnimes.Size = new System.Drawing.Size(194, 62);
            this.btnAnimes.TabIndex = 10;
            this.btnAnimes.Text = "Animes";
            this.btnAnimes.UseVisualStyleBackColor = true;
            this.btnAnimes.Click += new System.EventHandler(this.btnAnimes_Click);
            // 
            // panelSubMenuAnime
            // 
            this.panelSubMenuAnime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelSubMenuAnime.Controls.Add(this.btnBuscarAnimes);
            this.panelSubMenuAnime.Controls.Add(this.btnRegistrarEstudio);
            this.panelSubMenuAnime.Controls.Add(this.btnRegistrarGeneroA);
            this.panelSubMenuAnime.Controls.Add(this.btnRegistrarAnime);
            this.panelSubMenuAnime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAnime.Location = new System.Drawing.Point(0, 224);
            this.panelSubMenuAnime.Name = "panelSubMenuAnime";
            this.panelSubMenuAnime.Size = new System.Drawing.Size(194, 131);
            this.panelSubMenuAnime.TabIndex = 11;
            // 
            // btnMangas
            // 
            this.btnMangas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMangas.FlatAppearance.BorderSize = 0;
            this.btnMangas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnMangas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMangas.Image = ((System.Drawing.Image)(resources.GetObject("btnMangas.Image")));
            this.btnMangas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMangas.Location = new System.Drawing.Point(0, 355);
            this.btnMangas.Name = "btnMangas";
            this.btnMangas.Size = new System.Drawing.Size(194, 62);
            this.btnMangas.TabIndex = 12;
            this.btnMangas.Text = "Mangas";
            this.btnMangas.UseVisualStyleBackColor = true;
            this.btnMangas.Click += new System.EventHandler(this.btnMangas_Click);
            // 
            // panelSubMenuManga
            // 
            this.panelSubMenuManga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelSubMenuManga.Controls.Add(this.btnBuscarMangas);
            this.panelSubMenuManga.Controls.Add(this.btnRegistrarIlus);
            this.panelSubMenuManga.Controls.Add(this.btnRegistrarAutor);
            this.panelSubMenuManga.Controls.Add(this.btnRegistrarGeneroM);
            this.panelSubMenuManga.Controls.Add(this.btnRegistrarManga);
            this.panelSubMenuManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuManga.Location = new System.Drawing.Point(0, 417);
            this.panelSubMenuManga.Name = "panelSubMenuManga";
            this.panelSubMenuManga.Size = new System.Drawing.Size(194, 165);
            this.panelSubMenuManga.TabIndex = 13;
            // 
            // btnRegistrarAnime
            // 
            this.btnRegistrarAnime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarAnime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarAnime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarAnime.FlatAppearance.BorderSize = 0;
            this.btnRegistrarAnime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnRegistrarAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAnime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAnime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarAnime.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarAnime.Name = "btnRegistrarAnime";
            this.btnRegistrarAnime.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarAnime.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarAnime.TabIndex = 0;
            this.btnRegistrarAnime.Text = "Registrar Anime";
            this.btnRegistrarAnime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarAnime.UseVisualStyleBackColor = false;
            this.btnRegistrarAnime.Click += new System.EventHandler(this.btnRegistrarAnime_Click);
            // 
            // btnRegistrarGeneroA
            // 
            this.btnRegistrarGeneroA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarGeneroA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarGeneroA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarGeneroA.FlatAppearance.BorderSize = 0;
            this.btnRegistrarGeneroA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnRegistrarGeneroA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarGeneroA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarGeneroA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarGeneroA.Location = new System.Drawing.Point(0, 32);
            this.btnRegistrarGeneroA.Name = "btnRegistrarGeneroA";
            this.btnRegistrarGeneroA.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarGeneroA.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarGeneroA.TabIndex = 1;
            this.btnRegistrarGeneroA.Text = "Registrar Género ";
            this.btnRegistrarGeneroA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarGeneroA.UseVisualStyleBackColor = false;
            this.btnRegistrarGeneroA.Click += new System.EventHandler(this.btnRegistrarGeneroA_Click);
            // 
            // btnRegistrarEstudio
            // 
            this.btnRegistrarEstudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarEstudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarEstudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarEstudio.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEstudio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnRegistrarEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEstudio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEstudio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarEstudio.Location = new System.Drawing.Point(0, 64);
            this.btnRegistrarEstudio.Name = "btnRegistrarEstudio";
            this.btnRegistrarEstudio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarEstudio.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarEstudio.TabIndex = 2;
            this.btnRegistrarEstudio.Text = "Registrar Estudio";
            this.btnRegistrarEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarEstudio.UseVisualStyleBackColor = false;
            this.btnRegistrarEstudio.Click += new System.EventHandler(this.btnRegistrarEstudio_Click);
            // 
            // btnBuscarAnimes
            // 
            this.btnBuscarAnimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarAnimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAnimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarAnimes.FlatAppearance.BorderSize = 0;
            this.btnBuscarAnimes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnBuscarAnimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAnimes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAnimes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarAnimes.Location = new System.Drawing.Point(0, 96);
            this.btnBuscarAnimes.Name = "btnBuscarAnimes";
            this.btnBuscarAnimes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBuscarAnimes.Size = new System.Drawing.Size(194, 32);
            this.btnBuscarAnimes.TabIndex = 3;
            this.btnBuscarAnimes.Text = "Buscar Animes";
            this.btnBuscarAnimes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAnimes.UseVisualStyleBackColor = false;
            this.btnBuscarAnimes.Click += new System.EventHandler(this.btnBuscarAnimes_Click);
            // 
            // btnRegistrarManga
            // 
            this.btnRegistrarManga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarManga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarManga.FlatAppearance.BorderSize = 0;
            this.btnRegistrarManga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnRegistrarManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarManga.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarManga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarManga.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarManga.Name = "btnRegistrarManga";
            this.btnRegistrarManga.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarManga.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarManga.TabIndex = 0;
            this.btnRegistrarManga.Text = "Registrar Manga";
            this.btnRegistrarManga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarManga.UseVisualStyleBackColor = false;
            this.btnRegistrarManga.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnRegistrarGeneroM
            // 
            this.btnRegistrarGeneroM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarGeneroM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarGeneroM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarGeneroM.FlatAppearance.BorderSize = 0;
            this.btnRegistrarGeneroM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnRegistrarGeneroM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarGeneroM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarGeneroM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarGeneroM.Location = new System.Drawing.Point(0, 32);
            this.btnRegistrarGeneroM.Name = "btnRegistrarGeneroM";
            this.btnRegistrarGeneroM.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarGeneroM.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarGeneroM.TabIndex = 1;
            this.btnRegistrarGeneroM.Text = "Registrar Género";
            this.btnRegistrarGeneroM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarGeneroM.UseVisualStyleBackColor = false;
            this.btnRegistrarGeneroM.Click += new System.EventHandler(this.btnRegistrarGeneroM_Click);
            // 
            // btnRegistrarAutor
            // 
            this.btnRegistrarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarAutor.FlatAppearance.BorderSize = 0;
            this.btnRegistrarAutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnRegistrarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAutor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarAutor.Location = new System.Drawing.Point(0, 64);
            this.btnRegistrarAutor.Name = "btnRegistrarAutor";
            this.btnRegistrarAutor.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarAutor.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarAutor.TabIndex = 2;
            this.btnRegistrarAutor.Text = "Registrar Autor";
            this.btnRegistrarAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarAutor.UseVisualStyleBackColor = false;
            this.btnRegistrarAutor.Click += new System.EventHandler(this.btnRegistrarAutor_Click);
            // 
            // btnRegistrarIlus
            // 
            this.btnRegistrarIlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarIlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarIlus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarIlus.FlatAppearance.BorderSize = 0;
            this.btnRegistrarIlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnRegistrarIlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarIlus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarIlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarIlus.Location = new System.Drawing.Point(0, 96);
            this.btnRegistrarIlus.Name = "btnRegistrarIlus";
            this.btnRegistrarIlus.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarIlus.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarIlus.TabIndex = 3;
            this.btnRegistrarIlus.Text = "Registrar Ilustrador";
            this.btnRegistrarIlus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarIlus.UseVisualStyleBackColor = false;
            this.btnRegistrarIlus.Click += new System.EventHandler(this.btnRegistrarIlus_Click);
            // 
            // btnBuscarMangas
            // 
            this.btnBuscarMangas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarMangas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMangas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarMangas.FlatAppearance.BorderSize = 0;
            this.btnBuscarMangas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnBuscarMangas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMangas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMangas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarMangas.Location = new System.Drawing.Point(0, 128);
            this.btnBuscarMangas.Name = "btnBuscarMangas";
            this.btnBuscarMangas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBuscarMangas.Size = new System.Drawing.Size(194, 34);
            this.btnBuscarMangas.TabIndex = 4;
            this.btnBuscarMangas.Text = "Buscar Mangas";
            this.btnBuscarMangas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarMangas.UseVisualStyleBackColor = false;
            this.btnBuscarMangas.Click += new System.EventHandler(this.btnBuscarMangas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 582);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(194, 62);
            this.btnUsuarios.TabIndex = 14;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panelSubMenuUsuarios
            // 
            this.panelSubMenuUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelSubMenuUsuarios.Controls.Add(this.btnBuscarUsuarios);
            this.panelSubMenuUsuarios.Controls.Add(this.btnRegistrarUsuario);
            this.panelSubMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuUsuarios.Location = new System.Drawing.Point(0, 644);
            this.panelSubMenuUsuarios.Name = "panelSubMenuUsuarios";
            this.panelSubMenuUsuarios.Size = new System.Drawing.Size(194, 67);
            this.panelSubMenuUsuarios.TabIndex = 15;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(194, 32);
            this.btnRegistrarUsuario.TabIndex = 1;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnBuscarUsuarios
            // 
            this.btnBuscarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnBuscarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarUsuarios.Location = new System.Drawing.Point(0, 32);
            this.btnBuscarUsuarios.Name = "btnBuscarUsuarios";
            this.btnBuscarUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBuscarUsuarios.Size = new System.Drawing.Size(194, 32);
            this.btnBuscarUsuarios.TabIndex = 2;
            this.btnBuscarUsuarios.Text = "Buscar Usuarios";
            this.btnBuscarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUsuarios.UseVisualStyleBackColor = false;
            this.btnBuscarUsuarios.Click += new System.EventHandler(this.btnBuscarUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(211, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 600);
            this.panel1.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSubMenuAnime.ResumeLayout(false);
            this.panelSubMenuManga.ResumeLayout(false);
            this.panelSubMenuUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSubMenuManga;
        private System.Windows.Forms.Button btnRegistrarIlus;
        private System.Windows.Forms.Button btnRegistrarAutor;
        private System.Windows.Forms.Button btnRegistrarGeneroM;
        private System.Windows.Forms.Button btnRegistrarManga;
        private System.Windows.Forms.Button btnMangas;
        private System.Windows.Forms.Panel panelSubMenuAnime;
        private System.Windows.Forms.Button btnBuscarAnimes;
        private System.Windows.Forms.Button btnRegistrarEstudio;
        private System.Windows.Forms.Button btnRegistrarGeneroA;
        private System.Windows.Forms.Button btnRegistrarAnime;
        private System.Windows.Forms.Button btnAnimes;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnBuscarMangas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panelSubMenuUsuarios;
        private System.Windows.Forms.Button btnBuscarUsuarios;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}