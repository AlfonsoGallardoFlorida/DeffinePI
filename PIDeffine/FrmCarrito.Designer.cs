
namespace PIDeffine
{
    partial class FrmCarrito
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
            this.paneldecontrol = new System.Windows.Forms.Panel();
            this.pcbCerrar = new System.Windows.Forms.PictureBox();
            this.pcbMinimizar = new System.Windows.Forms.PictureBox();
            this.pcbLogOut = new System.Windows.Forms.PictureBox();
            this.pcbPerfil = new System.Windows.Forms.PictureBox();
            this.lblContacta = new System.Windows.Forms.Label();
            this.pcbDeffine = new System.Windows.Forms.PictureBox();
            this.pcbspain = new System.Windows.Forms.PictureBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.pcbingle = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbPrincipal = new System.Windows.Forms.PictureBox();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.cmbTalla = new System.Windows.Forms.ComboBox();
            this.bttFiltrar = new System.Windows.Forms.Button();
            this.lblColecciones = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblFiltrarCarro = new System.Windows.Forms.Label();
            this.pcbFiltros = new System.Windows.Forms.PictureBox();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.panelColecciones = new System.Windows.Forms.Panel();
            this.rdbDisenyo = new System.Windows.Forms.RadioButton();
            this.rdbPantalones = new System.Windows.Forms.RadioButton();
            this.rdbCamisetas = new System.Windows.Forms.RadioButton();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.bttComprar = new System.Windows.Forms.Button();
            this.bttEliminarCarrito = new System.Windows.Forms.Button();
            this.pcbVolver = new System.Windows.Forms.PictureBox();
            this.paneldecontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeffine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbspain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.panelColecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldecontrol
            // 
            this.paneldecontrol.BackColor = System.Drawing.Color.DimGray;
            this.paneldecontrol.Controls.Add(this.pcbVolver);
            this.paneldecontrol.Controls.Add(this.pcbCerrar);
            this.paneldecontrol.Controls.Add(this.pcbMinimizar);
            this.paneldecontrol.Controls.Add(this.pcbLogOut);
            this.paneldecontrol.Location = new System.Drawing.Point(-3, -14);
            this.paneldecontrol.Name = "paneldecontrol";
            this.paneldecontrol.Size = new System.Drawing.Size(1022, 55);
            this.paneldecontrol.TabIndex = 25;
            this.paneldecontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneldecontrol_MouseDown);
            this.paneldecontrol.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneldecontrol_MouseMove);
            this.paneldecontrol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneldecontrol_MouseUp);
            // 
            // pcbCerrar
            // 
            this.pcbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCerrar.Image = global::PIDeffine.Properties.Resources.cerrar;
            this.pcbCerrar.Location = new System.Drawing.Point(953, 17);
            this.pcbCerrar.Name = "pcbCerrar";
            this.pcbCerrar.Size = new System.Drawing.Size(41, 35);
            this.pcbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCerrar.TabIndex = 24;
            this.pcbCerrar.TabStop = false;
            this.pcbCerrar.Click += new System.EventHandler(this.pcbCerrar_Click);
            // 
            // pcbMinimizar
            // 
            this.pcbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMinimizar.Image = global::PIDeffine.Properties.Resources.minimizzar;
            this.pcbMinimizar.Location = new System.Drawing.Point(910, 17);
            this.pcbMinimizar.Name = "pcbMinimizar";
            this.pcbMinimizar.Size = new System.Drawing.Size(37, 35);
            this.pcbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMinimizar.TabIndex = 0;
            this.pcbMinimizar.TabStop = false;
            this.pcbMinimizar.Click += new System.EventHandler(this.pcbMinimizar_Click);
            // 
            // pcbLogOut
            // 
            this.pcbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbLogOut.Image = global::PIDeffine.Properties.Resources.loguott;
            this.pcbLogOut.Location = new System.Drawing.Point(866, 17);
            this.pcbLogOut.Name = "pcbLogOut";
            this.pcbLogOut.Size = new System.Drawing.Size(38, 35);
            this.pcbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogOut.TabIndex = 26;
            this.pcbLogOut.TabStop = false;
            this.pcbLogOut.Click += new System.EventHandler(this.pcbLogOut_Click);
            // 
            // pcbPerfil
            // 
            this.pcbPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPerfil.Image = global::PIDeffine.Properties.Resources.Ellipse_2;
            this.pcbPerfil.Location = new System.Drawing.Point(885, 62);
            this.pcbPerfil.Name = "pcbPerfil";
            this.pcbPerfil.Size = new System.Drawing.Size(69, 67);
            this.pcbPerfil.TabIndex = 54;
            this.pcbPerfil.TabStop = false;
            // 
            // lblContacta
            // 
            this.lblContacta.AutoSize = true;
            this.lblContacta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContacta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacta.ForeColor = System.Drawing.Color.White;
            this.lblContacta.Location = new System.Drawing.Point(668, 79);
            this.lblContacta.Name = "lblContacta";
            this.lblContacta.Size = new System.Drawing.Size(211, 25);
            this.lblContacta.TabIndex = 53;
            this.lblContacta.Text = "Contacta con Nosotros";
            // 
            // pcbDeffine
            // 
            this.pcbDeffine.Image = global::PIDeffine.Properties.Resources.deffinneeHeader;
            this.pcbDeffine.Location = new System.Drawing.Point(294, 64);
            this.pcbDeffine.Name = "pcbDeffine";
            this.pcbDeffine.Size = new System.Drawing.Size(312, 65);
            this.pcbDeffine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDeffine.TabIndex = 52;
            this.pcbDeffine.TabStop = false;
            // 
            // pcbspain
            // 
            this.pcbspain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbspain.Image = global::PIDeffine.Properties.Resources.image_removebg_preview__13_;
            this.pcbspain.Location = new System.Drawing.Point(60, 64);
            this.pcbspain.Name = "pcbspain";
            this.pcbspain.Size = new System.Drawing.Size(56, 53);
            this.pcbspain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbspain.TabIndex = 50;
            this.pcbspain.TabStop = false;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(111, 79);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(70, 25);
            this.lblIdioma.TabIndex = 51;
            this.lblIdioma.Text = "Idioma";
            // 
            // pcbingle
            // 
            this.pcbingle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbingle.Image = global::PIDeffine.Properties.Resources.engli1;
            this.pcbingle.Location = new System.Drawing.Point(60, 64);
            this.pcbingle.Name = "pcbingle";
            this.pcbingle.Size = new System.Drawing.Size(56, 52);
            this.pcbingle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbingle.TabIndex = 55;
            this.pcbingle.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-3, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1007, 706);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pcbPrincipal
            // 
            this.pcbPrincipal.Image = global::PIDeffine.Properties.Resources.FONDOGRISS;
            this.pcbPrincipal.Location = new System.Drawing.Point(12, 157);
            this.pcbPrincipal.Name = "pcbPrincipal";
            this.pcbPrincipal.Size = new System.Drawing.Size(952, 585);
            this.pcbPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPrincipal.TabIndex = 58;
            this.pcbPrincipal.TabStop = false;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblCarrito.Font = new System.Drawing.Font("Arial", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCarrito.ForeColor = System.Drawing.Color.White;
            this.lblCarrito.Location = new System.Drawing.Point(475, 177);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(212, 49);
            this.lblCarrito.TabIndex = 59;
            this.lblCarrito.Text = "CARRITO";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(258, 235);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.RowTemplate.Height = 24;
            this.dgvCarrito.Size = new System.Drawing.Size(686, 343);
            this.dgvCarrito.TabIndex = 60;
            // 
            // cmbTalla
            // 
            this.cmbTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTalla.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cmbTalla.Location = new System.Drawing.Point(32, 316);
            this.cmbTalla.Name = "cmbTalla";
            this.cmbTalla.Size = new System.Drawing.Size(193, 31);
            this.cmbTalla.TabIndex = 61;
            // 
            // bttFiltrar
            // 
            this.bttFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bttFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttFiltrar.FlatAppearance.BorderSize = 0;
            this.bttFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFiltrar.ForeColor = System.Drawing.Color.White;
            this.bttFiltrar.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.bttFiltrar.Location = new System.Drawing.Point(49, 498);
            this.bttFiltrar.Name = "bttFiltrar";
            this.bttFiltrar.Size = new System.Drawing.Size(156, 36);
            this.bttFiltrar.TabIndex = 75;
            this.bttFiltrar.Text = "Filtrar";
            this.bttFiltrar.UseVisualStyleBackColor = false;
            // 
            // lblColecciones
            // 
            this.lblColecciones.AutoSize = true;
            this.lblColecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblColecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColecciones.ForeColor = System.Drawing.Color.White;
            this.lblColecciones.Location = new System.Drawing.Point(27, 548);
            this.lblColecciones.Name = "lblColecciones";
            this.lblColecciones.Size = new System.Drawing.Size(120, 25);
            this.lblColecciones.TabIndex = 66;
            this.lblColecciones.Text = "Colecciones";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.lblTalla.ForeColor = System.Drawing.Color.White;
            this.lblTalla.Location = new System.Drawing.Point(28, 274);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(55, 25);
            this.lblTalla.TabIndex = 64;
            this.lblTalla.Text = "Talla";
            // 
            // lblFiltrarCarro
            // 
            this.lblFiltrarCarro.AutoSize = true;
            this.lblFiltrarCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblFiltrarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFiltrarCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lblFiltrarCarro.Location = new System.Drawing.Point(61, 197);
            this.lblFiltrarCarro.Name = "lblFiltrarCarro";
            this.lblFiltrarCarro.Size = new System.Drawing.Size(146, 29);
            this.lblFiltrarCarro.TabIndex = 63;
            this.lblFiltrarCarro.Text = "Filtrar Carro";
            // 
            // pcbFiltros
            // 
            this.pcbFiltros.Image = global::PIDeffine.Properties.Resources.Group11;
            this.pcbFiltros.Location = new System.Drawing.Point(14, 163);
            this.pcbFiltros.Name = "pcbFiltros";
            this.pcbFiltros.Size = new System.Drawing.Size(238, 606);
            this.pcbFiltros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFiltros.TabIndex = 62;
            this.pcbFiltros.TabStop = false;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(179, 455);
            this.nudMax.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(47, 30);
            this.nudMax.TabIndex = 81;
            this.nudMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(179, 415);
            this.nudMin.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(47, 30);
            this.nudMin.TabIndex = 77;
            this.nudMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // panelColecciones
            // 
            this.panelColecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelColecciones.Controls.Add(this.rdbDisenyo);
            this.panelColecciones.Controls.Add(this.rdbPantalones);
            this.panelColecciones.Controls.Add(this.rdbCamisetas);
            this.panelColecciones.ForeColor = System.Drawing.Color.White;
            this.panelColecciones.Location = new System.Drawing.Point(26, 578);
            this.panelColecciones.Name = "panelColecciones";
            this.panelColecciones.Size = new System.Drawing.Size(208, 120);
            this.panelColecciones.TabIndex = 76;
            // 
            // rdbDisenyo
            // 
            this.rdbDisenyo.AutoSize = true;
            this.rdbDisenyo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDisenyo.Location = new System.Drawing.Point(3, 71);
            this.rdbDisenyo.Name = "rdbDisenyo";
            this.rdbDisenyo.Size = new System.Drawing.Size(92, 27);
            this.rdbDisenyo.TabIndex = 2;
            this.rdbDisenyo.TabStop = true;
            this.rdbDisenyo.Text = "Diseño";
            this.rdbDisenyo.UseVisualStyleBackColor = true;
            // 
            // rdbPantalones
            // 
            this.rdbPantalones.AutoSize = true;
            this.rdbPantalones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbPantalones.Location = new System.Drawing.Point(3, 36);
            this.rdbPantalones.Name = "rdbPantalones";
            this.rdbPantalones.Size = new System.Drawing.Size(128, 27);
            this.rdbPantalones.TabIndex = 1;
            this.rdbPantalones.TabStop = true;
            this.rdbPantalones.Text = "Pantalones";
            this.rdbPantalones.UseVisualStyleBackColor = true;
            // 
            // rdbCamisetas
            // 
            this.rdbCamisetas.AutoSize = true;
            this.rdbCamisetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbCamisetas.Location = new System.Drawing.Point(3, 3);
            this.rdbCamisetas.Name = "rdbCamisetas";
            this.rdbCamisetas.Size = new System.Drawing.Size(124, 27);
            this.rdbCamisetas.TabIndex = 0;
            this.rdbCamisetas.TabStop = true;
            this.rdbCamisetas.Text = "Camisetas";
            this.rdbCamisetas.UseVisualStyleBackColor = true;
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.ForeColor = System.Drawing.Color.White;
            this.lblMinimo.Location = new System.Drawing.Point(29, 422);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(74, 23);
            this.lblMinimo.TabIndex = 80;
            this.lblMinimo.Text = "Mínimo";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.ForeColor = System.Drawing.Color.White;
            this.lblMaximo.Location = new System.Drawing.Point(29, 455);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(78, 23);
            this.lblMaximo.TabIndex = 79;
            this.lblMaximo.Text = "Máximo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(28, 389);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(66, 23);
            this.lblPrecio.TabIndex = 78;
            this.lblPrecio.Text = "Precio";
            // 
            // bttComprar
            // 
            this.bttComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bttComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttComprar.FlatAppearance.BorderSize = 0;
            this.bttComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttComprar.ForeColor = System.Drawing.Color.White;
            this.bttComprar.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.bttComprar.Location = new System.Drawing.Point(602, 649);
            this.bttComprar.Name = "bttComprar";
            this.bttComprar.Size = new System.Drawing.Size(342, 57);
            this.bttComprar.TabIndex = 82;
            this.bttComprar.Text = "Comprar Ahora";
            this.bttComprar.UseVisualStyleBackColor = false;
            // 
            // bttEliminarCarrito
            // 
            this.bttEliminarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bttEliminarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttEliminarCarrito.FlatAppearance.BorderSize = 0;
            this.bttEliminarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEliminarCarrito.ForeColor = System.Drawing.Color.White;
            this.bttEliminarCarrito.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.bttEliminarCarrito.Location = new System.Drawing.Point(254, 649);
            this.bttEliminarCarrito.Name = "bttEliminarCarrito";
            this.bttEliminarCarrito.Size = new System.Drawing.Size(342, 57);
            this.bttEliminarCarrito.TabIndex = 83;
            this.bttEliminarCarrito.Text = "Eliminar Carrito";
            this.bttEliminarCarrito.UseVisualStyleBackColor = false;
            // 
            // pcbVolver
            // 
            this.pcbVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVolver.Image = global::PIDeffine.Properties.Resources.image_removebg_preview__13_1;
            this.pcbVolver.Location = new System.Drawing.Point(17, 17);
            this.pcbVolver.Name = "pcbVolver";
            this.pcbVolver.Size = new System.Drawing.Size(38, 35);
            this.pcbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVolver.TabIndex = 28;
            this.pcbVolver.TabStop = false;
            this.pcbVolver.Click += new System.EventHandler(this.pcbVolver_Click);
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1004, 735);
            this.Controls.Add(this.bttEliminarCarrito);
            this.Controls.Add(this.bttComprar);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.panelColecciones);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cmbTalla);
            this.Controls.Add(this.bttFiltrar);
            this.Controls.Add(this.lblColecciones);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.lblFiltrarCarro);
            this.Controls.Add(this.pcbFiltros);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.pcbPrincipal);
            this.Controls.Add(this.pcbPerfil);
            this.Controls.Add(this.paneldecontrol);
            this.Controls.Add(this.lblContacta);
            this.Controls.Add(this.pcbDeffine);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.pcbspain);
            this.Controls.Add(this.pcbingle);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarrito";
            this.Load += new System.EventHandler(this.FrmCarrito_Load);
            this.paneldecontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeffine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbspain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.panelColecciones.ResumeLayout(false);
            this.panelColecciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneldecontrol;
        private System.Windows.Forms.PictureBox pcbCerrar;
        private System.Windows.Forms.PictureBox pcbMinimizar;
        private System.Windows.Forms.PictureBox pcbLogOut;
        private System.Windows.Forms.PictureBox pcbPerfil;
        private System.Windows.Forms.Label lblContacta;
        private System.Windows.Forms.PictureBox pcbDeffine;
        private System.Windows.Forms.PictureBox pcbspain;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.PictureBox pcbingle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbPrincipal;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.ComboBox cmbTalla;
        private System.Windows.Forms.Button bttFiltrar;
        private System.Windows.Forms.Label lblColecciones;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblFiltrarCarro;
        private System.Windows.Forms.PictureBox pcbFiltros;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Panel panelColecciones;
        private System.Windows.Forms.RadioButton rdbDisenyo;
        private System.Windows.Forms.RadioButton rdbPantalones;
        private System.Windows.Forms.RadioButton rdbCamisetas;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button bttComprar;
        private System.Windows.Forms.Button bttEliminarCarrito;
        private System.Windows.Forms.PictureBox pcbVolver;
    }
}