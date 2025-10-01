namespace Visor_de_imagenes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.visionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNormal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEscalaGrises = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCentrada = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAjustada = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoom = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.chkEscalaGrises = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbCentrada = new System.Windows.Forms.RadioButton();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.rbAjustar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxImagenes = new System.Windows.Forms.ComboBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.girar90GradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girar90GradosALaDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarAlPortapapelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.aToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 34);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.visionToolStripMenuItem,
            this.tamañoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGuardar,
            this.menuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menuGuardar
            // 
            this.menuGuardar.Name = "menuGuardar";
            this.menuGuardar.Size = new System.Drawing.Size(177, 34);
            this.menuGuardar.Text = "Guardar";
            this.menuGuardar.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(177, 34);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // visionToolStripMenuItem
            // 
            this.visionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem});
            this.visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            this.visionToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.visionToolStripMenuItem.Text = "Vision";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // tamañoToolStripMenuItem
            // 
            this.tamañoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centradaToolStripMenuItem,
            this.ajustadaToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            this.tamañoToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.tamañoToolStripMenuItem.Text = "Tamaño";
            // 
            // centradaToolStripMenuItem
            // 
            this.centradaToolStripMenuItem.Name = "centradaToolStripMenuItem";
            this.centradaToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.centradaToolStripMenuItem.Text = "Centrada";
            this.centradaToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonCentrada_Click);
            // 
            // ajustadaToolStripMenuItem
            // 
            this.ajustadaToolStripMenuItem.Name = "ajustadaToolStripMenuItem";
            this.ajustadaToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.ajustadaToolStripMenuItem.Text = "Ajustar";
            this.ajustadaToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAjustada_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonZoom_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNormal,
            this.toolStripButtonEscalaGrises,
            this.toolStripButtonCentrada,
            this.toolStripButtonAjustada,
            this.toolStripButtonZoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1095, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNormal
            // 
            this.toolStripButtonNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNormal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNormal.Image")));
            this.toolStripButtonNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNormal.Name = "toolStripButtonNormal";
            this.toolStripButtonNormal.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonNormal.Text = "toolStripButton1";
            this.toolStripButtonNormal.Click += new System.EventHandler(this.toolStripButtonNormal_Click);
            // 
            // toolStripButtonEscalaGrises
            // 
            this.toolStripButtonEscalaGrises.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEscalaGrises.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEscalaGrises.Image")));
            this.toolStripButtonEscalaGrises.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEscalaGrises.Name = "toolStripButtonEscalaGrises";
            this.toolStripButtonEscalaGrises.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonEscalaGrises.Text = "toolStripButton2";
            this.toolStripButtonEscalaGrises.Click += new System.EventHandler(this.toolStripButtonEscalaGrises_Click);
            // 
            // toolStripButtonCentrada
            // 
            this.toolStripButtonCentrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCentrada.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCentrada.Image")));
            this.toolStripButtonCentrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCentrada.Name = "toolStripButtonCentrada";
            this.toolStripButtonCentrada.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonCentrada.Text = "toolStripButton3";
            this.toolStripButtonCentrada.Click += new System.EventHandler(this.toolStripButtonCentrada_Click);
            // 
            // toolStripButtonAjustada
            // 
            this.toolStripButtonAjustada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAjustada.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAjustada.Image")));
            this.toolStripButtonAjustada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAjustada.Name = "toolStripButtonAjustada";
            this.toolStripButtonAjustada.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonAjustada.Text = "toolStripButton4";
            this.toolStripButtonAjustada.Click += new System.EventHandler(this.toolStripButtonAjustada_Click);
            // 
            // toolStripButtonZoom
            // 
            this.toolStripButtonZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoom.Image")));
            this.toolStripButtonZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoom.Name = "toolStripButtonZoom";
            this.toolStripButtonZoom.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonZoom.Text = "toolStripButton5";
            this.toolStripButtonZoom.Click += new System.EventHandler(this.toolStripButtonZoom_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(132, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 89);
            this.label1.TabIndex = 2;
            this.label1.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(900, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 215);
            this.label2.TabIndex = 3;
            this.label2.Text = "\r\n";
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkNormal.Location = new System.Drawing.Point(213, 126);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(85, 24);
            this.chkNormal.TabIndex = 4;
            this.chkNormal.Text = "Normal";
            this.chkNormal.UseVisualStyleBackColor = true;
            this.chkNormal.CheckedChanged += new System.EventHandler(this.chkNormal_CheckedChanged);
            // 
            // chkEscalaGrises
            // 
            this.chkEscalaGrises.AutoSize = true;
            this.chkEscalaGrises.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEscalaGrises.Location = new System.Drawing.Point(617, 126);
            this.chkEscalaGrises.Name = "chkEscalaGrises";
            this.chkEscalaGrises.Size = new System.Drawing.Size(155, 24);
            this.chkEscalaGrises.TabIndex = 5;
            this.chkEscalaGrises.Text = "Escala de Grises";
            this.chkEscalaGrises.UseVisualStyleBackColor = true;
            this.chkEscalaGrises.CheckedChanged += new System.EventHandler(this.chkEscalaGrises_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(159, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(934, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tamaño";
            // 
            // rbCentrada
            // 
            this.rbCentrada.AutoSize = true;
            this.rbCentrada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbCentrada.Location = new System.Drawing.Point(938, 137);
            this.rbCentrada.Name = "rbCentrada";
            this.rbCentrada.Size = new System.Drawing.Size(100, 24);
            this.rbCentrada.TabIndex = 8;
            this.rbCentrada.TabStop = true;
            this.rbCentrada.Text = "Centrada";
            this.rbCentrada.UseVisualStyleBackColor = true;
            this.rbCentrada.CheckedChanged += new System.EventHandler(this.rbCentrada_CheckedChanged);
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbZoom.Location = new System.Drawing.Point(938, 253);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(75, 24);
            this.rbZoom.TabIndex = 9;
            this.rbZoom.TabStop = true;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.rbZoom_CheckedChanged);
            // 
            // rbAjustar
            // 
            this.rbAjustar.AutoSize = true;
            this.rbAjustar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAjustar.Location = new System.Drawing.Point(938, 193);
            this.rbAjustar.Name = "rbAjustar";
            this.rbAjustar.Size = new System.Drawing.Size(84, 24);
            this.rbAjustar.TabIndex = 10;
            this.rbAjustar.TabStop = true;
            this.rbAjustar.Text = "Ajustar";
            this.rbAjustar.UseVisualStyleBackColor = true;
            this.rbAjustar.CheckedChanged += new System.EventHandler(this.rbAjustar_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(323, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Imagen Actual";
            // 
            // comboBoxImagenes
            // 
            this.comboBoxImagenes.FormattingEnabled = true;
            this.comboBoxImagenes.Location = new System.Drawing.Point(442, 215);
            this.comboBoxImagenes.Name = "comboBoxImagenes";
            this.comboBoxImagenes.Size = new System.Drawing.Size(224, 28);
            this.comboBoxImagenes.TabIndex = 12;
            this.comboBoxImagenes.SelectedIndexChanged += new System.EventHandler(this.comboBoxImagenes_SelectedIndexChanged);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrimero.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPrimero.FlatAppearance.BorderSize = 4;
            this.btnPrimero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPrimero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrimero.Location = new System.Drawing.Point(197, 609);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(122, 38);
            this.btnPrimero.TabIndex = 13;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUltimo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnUltimo.FlatAppearance.BorderSize = 4;
            this.btnUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUltimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUltimo.Location = new System.Drawing.Point(687, 609);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(122, 38);
            this.btnUltimo.TabIndex = 14;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSiguiente.FlatAppearance.BorderSize = 4;
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSiguiente.Location = new System.Drawing.Point(540, 609);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(112, 38);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAnterior.FlatAppearance.BorderSize = 4;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnterior.Location = new System.Drawing.Point(374, 609);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(112, 38);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 32);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(179, 25);
            this.lblEstado.Text = "toolStripStatusLabel1";
            // 
            // pictureBox
            // 
            this.pictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox.Location = new System.Drawing.Point(213, 249);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(612, 315);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 19;
            this.pictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girar90GradosToolStripMenuItem,
            this.girar90GradosALaDerechaToolStripMenuItem,
            this.copiarAlPortapapelesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip3";
            this.contextMenuStrip1.Size = new System.Drawing.Size(316, 100);
            // 
            // girar90GradosToolStripMenuItem
            // 
            this.girar90GradosToolStripMenuItem.Name = "girar90GradosToolStripMenuItem";
            this.girar90GradosToolStripMenuItem.Size = new System.Drawing.Size(315, 32);
            this.girar90GradosToolStripMenuItem.Text = "girar 90 grados a la izquierda";
            this.girar90GradosToolStripMenuItem.Click += new System.EventHandler(this.rotarIzquierdaToolStripMenuItem_Click);
            // 
            // girar90GradosALaDerechaToolStripMenuItem
            // 
            this.girar90GradosALaDerechaToolStripMenuItem.Name = "girar90GradosALaDerechaToolStripMenuItem";
            this.girar90GradosALaDerechaToolStripMenuItem.Size = new System.Drawing.Size(315, 32);
            this.girar90GradosALaDerechaToolStripMenuItem.Text = "girar 90 grados a la derecha";
            this.girar90GradosALaDerechaToolStripMenuItem.Click += new System.EventHandler(this.rotarDerechaToolStripMenuItem_Click);
            // 
            // copiarAlPortapapelesToolStripMenuItem
            // 
            this.copiarAlPortapapelesToolStripMenuItem.Name = "copiarAlPortapapelesToolStripMenuItem";
            this.copiarAlPortapapelesToolStripMenuItem.Size = new System.Drawing.Size(315, 32);
            this.copiarAlPortapapelesToolStripMenuItem.Text = "copiar al portapapeles";
            this.copiarAlPortapapelesToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 682);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.comboBoxImagenes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbAjustar);
            this.Controls.Add(this.rbZoom);
            this.Controls.Add(this.rbCentrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkEscalaGrises);
            this.Controls.Add(this.chkNormal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGuardar;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamañoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.CheckBox chkEscalaGrises;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCentrada;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.RadioButton rbAjustar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxImagenes;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEscalaGrises;
        private System.Windows.Forms.ToolStripButton toolStripButtonCentrada;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonAjustada;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoom;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girar90GradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girar90GradosALaDerechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarAlPortapapelesToolStripMenuItem;
    }
}

