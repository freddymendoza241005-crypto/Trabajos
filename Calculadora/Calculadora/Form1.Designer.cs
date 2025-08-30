namespace Calculadora
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
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.Btigual = new System.Windows.Forms.Button();
            this.Btsuma = new System.Windows.Forms.Button();
            this.Btmultiplicacion = new System.Windows.Forms.Button();
            this.Btresta = new System.Windows.Forms.Button();
            this.Btdividir = new System.Windows.Forms.Button();
            this.Btborrarpantalla = new System.Windows.Forms.Button();
            this.Btnueve = new System.Windows.Forms.Button();
            this.Btseis = new System.Windows.Forms.Button();
            this.Bttres = new System.Windows.Forms.Button();
            this.Btpunto = new System.Windows.Forms.Button();
            this.Btocho = new System.Windows.Forms.Button();
            this.Btcinco = new System.Windows.Forms.Button();
            this.Btdos = new System.Windows.Forms.Button();
            this.Btciete = new System.Windows.Forms.Button();
            this.Btcuatro = new System.Windows.Forms.Button();
            this.Btuno = new System.Windows.Forms.Button();
            this.Btcero = new System.Windows.Forms.Button();
            this.Btborrarcaracter = new System.Windows.Forms.Button();
            this.Btexponente = new System.Windows.Forms.Button();
            this.Btraiz = new System.Windows.Forms.Button();
            this.Btpi = new System.Windows.Forms.Button();
            this.Btlog = new System.Windows.Forms.Button();
            this.BtSen = new System.Windows.Forms.Button();
            this.BtCoseno = new System.Windows.Forms.Button();
            this.Btporciento = new System.Windows.Forms.Button();
            this.Btguardarenmemoria = new System.Windows.Forms.Button();
            this.Btrecuperarnumero = new System.Windows.Forms.Button();
            this.Btlimpiar = new System.Windows.Forms.Button();
            this.Btrestarguardado = new System.Windows.Forms.Button();
            this.Btsumarguardado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPantalla
            // 
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(14, 25);
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(422, 82);
            this.txtPantalla.TabIndex = 0;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btigual
            // 
            this.Btigual.BackColor = System.Drawing.Color.Plum;
            this.Btigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btigual.Location = new System.Drawing.Point(220, 510);
            this.Btigual.Name = "Btigual";
            this.Btigual.Size = new System.Drawing.Size(200, 55);
            this.Btigual.TabIndex = 1;
            this.Btigual.Text = "=";
            this.Btigual.UseVisualStyleBackColor = false;
            this.Btigual.Click += new System.EventHandler(this.Btigual_Click);
            // 
            // Btsuma
            // 
            this.Btsuma.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btsuma.Location = new System.Drawing.Point(323, 449);
            this.Btsuma.Name = "Btsuma";
            this.Btsuma.Size = new System.Drawing.Size(97, 55);
            this.Btsuma.TabIndex = 2;
            this.Btsuma.Text = "+";
            this.Btsuma.UseVisualStyleBackColor = true;
            this.Btsuma.Click += new System.EventHandler(this.Btsuma_Click);
            // 
            // Btmultiplicacion
            // 
            this.Btmultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btmultiplicacion.Location = new System.Drawing.Point(323, 328);
            this.Btmultiplicacion.Name = "Btmultiplicacion";
            this.Btmultiplicacion.Size = new System.Drawing.Size(97, 55);
            this.Btmultiplicacion.TabIndex = 4;
            this.Btmultiplicacion.Text = "x";
            this.Btmultiplicacion.UseVisualStyleBackColor = true;
            this.Btmultiplicacion.Click += new System.EventHandler(this.Btmultiplicacion_Click);
            // 
            // Btresta
            // 
            this.Btresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btresta.Location = new System.Drawing.Point(323, 389);
            this.Btresta.Name = "Btresta";
            this.Btresta.Size = new System.Drawing.Size(97, 55);
            this.Btresta.TabIndex = 3;
            this.Btresta.Text = "-";
            this.Btresta.UseVisualStyleBackColor = true;
            this.Btresta.Click += new System.EventHandler(this.Btresta_Click);
            // 
            // Btdividir
            // 
            this.Btdividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btdividir.Location = new System.Drawing.Point(323, 267);
            this.Btdividir.Name = "Btdividir";
            this.Btdividir.Size = new System.Drawing.Size(97, 55);
            this.Btdividir.TabIndex = 5;
            this.Btdividir.Text = "÷";
            this.Btdividir.UseVisualStyleBackColor = true;
            this.Btdividir.Click += new System.EventHandler(this.Btdividir_Click);
            // 
            // Btborrarpantalla
            // 
            this.Btborrarpantalla.BackColor = System.Drawing.Color.DarkOrange;
            this.Btborrarpantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btborrarpantalla.Location = new System.Drawing.Point(14, 265);
            this.Btborrarpantalla.Name = "Btborrarpantalla";
            this.Btborrarpantalla.Size = new System.Drawing.Size(141, 55);
            this.Btborrarpantalla.TabIndex = 10;
            this.Btborrarpantalla.Text = "CE";
            this.Btborrarpantalla.UseVisualStyleBackColor = false;
            this.Btborrarpantalla.Click += new System.EventHandler(this.Btborrarpantalla_Click);
            // 
            // Btnueve
            // 
            this.Btnueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnueve.Location = new System.Drawing.Point(220, 328);
            this.Btnueve.Name = "Btnueve";
            this.Btnueve.Size = new System.Drawing.Size(97, 55);
            this.Btnueve.TabIndex = 9;
            this.Btnueve.Text = "9";
            this.Btnueve.UseVisualStyleBackColor = true;
            this.Btnueve.Click += new System.EventHandler(this.Btnueve_Click);
            // 
            // Btseis
            // 
            this.Btseis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btseis.Location = new System.Drawing.Point(220, 389);
            this.Btseis.Name = "Btseis";
            this.Btseis.Size = new System.Drawing.Size(97, 55);
            this.Btseis.TabIndex = 8;
            this.Btseis.Text = "6";
            this.Btseis.UseVisualStyleBackColor = true;
            this.Btseis.Click += new System.EventHandler(this.Btseis_Click);
            // 
            // Bttres
            // 
            this.Bttres.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttres.Location = new System.Drawing.Point(220, 449);
            this.Bttres.Name = "Bttres";
            this.Bttres.Size = new System.Drawing.Size(97, 55);
            this.Bttres.TabIndex = 7;
            this.Bttres.Text = "3";
            this.Bttres.UseVisualStyleBackColor = true;
            this.Bttres.Click += new System.EventHandler(this.Bttres_Click);
            // 
            // Btpunto
            // 
            this.Btpunto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btpunto.Location = new System.Drawing.Point(14, 510);
            this.Btpunto.Name = "Btpunto";
            this.Btpunto.Size = new System.Drawing.Size(97, 55);
            this.Btpunto.TabIndex = 6;
            this.Btpunto.Text = ".";
            this.Btpunto.UseVisualStyleBackColor = false;
            this.Btpunto.Click += new System.EventHandler(this.Btpunto_Click);
            // 
            // Btocho
            // 
            this.Btocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btocho.Location = new System.Drawing.Point(117, 327);
            this.Btocho.Name = "Btocho";
            this.Btocho.Size = new System.Drawing.Size(97, 55);
            this.Btocho.TabIndex = 13;
            this.Btocho.Text = "8";
            this.Btocho.UseVisualStyleBackColor = true;
            this.Btocho.Click += new System.EventHandler(this.Btocho_Click);
            // 
            // Btcinco
            // 
            this.Btcinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btcinco.Location = new System.Drawing.Point(117, 388);
            this.Btcinco.Name = "Btcinco";
            this.Btcinco.Size = new System.Drawing.Size(97, 55);
            this.Btcinco.TabIndex = 12;
            this.Btcinco.Text = "5";
            this.Btcinco.UseVisualStyleBackColor = true;
            this.Btcinco.Click += new System.EventHandler(this.Btcinco_Click);
            // 
            // Btdos
            // 
            this.Btdos.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btdos.Location = new System.Drawing.Point(117, 448);
            this.Btdos.Name = "Btdos";
            this.Btdos.Size = new System.Drawing.Size(97, 55);
            this.Btdos.TabIndex = 11;
            this.Btdos.Text = "2";
            this.Btdos.UseVisualStyleBackColor = true;
            this.Btdos.Click += new System.EventHandler(this.Btdos_Click);
            // 
            // Btciete
            // 
            this.Btciete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btciete.Location = new System.Drawing.Point(14, 328);
            this.Btciete.Name = "Btciete";
            this.Btciete.Size = new System.Drawing.Size(97, 55);
            this.Btciete.TabIndex = 16;
            this.Btciete.Text = "7";
            this.Btciete.UseVisualStyleBackColor = true;
            this.Btciete.Click += new System.EventHandler(this.Btciete_Click);
            // 
            // Btcuatro
            // 
            this.Btcuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btcuatro.Location = new System.Drawing.Point(14, 389);
            this.Btcuatro.Name = "Btcuatro";
            this.Btcuatro.Size = new System.Drawing.Size(97, 55);
            this.Btcuatro.TabIndex = 15;
            this.Btcuatro.Text = "4";
            this.Btcuatro.UseVisualStyleBackColor = true;
            this.Btcuatro.Click += new System.EventHandler(this.Btcuatro_Click);
            // 
            // Btuno
            // 
            this.Btuno.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btuno.Location = new System.Drawing.Point(14, 449);
            this.Btuno.Name = "Btuno";
            this.Btuno.Size = new System.Drawing.Size(97, 55);
            this.Btuno.TabIndex = 14;
            this.Btuno.Text = "1";
            this.Btuno.UseVisualStyleBackColor = true;
            this.Btuno.Click += new System.EventHandler(this.Btuno_Click);
            // 
            // Btcero
            // 
            this.Btcero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btcero.Location = new System.Drawing.Point(117, 509);
            this.Btcero.Name = "Btcero";
            this.Btcero.Size = new System.Drawing.Size(97, 55);
            this.Btcero.TabIndex = 17;
            this.Btcero.Text = "0";
            this.Btcero.UseVisualStyleBackColor = true;
            this.Btcero.Click += new System.EventHandler(this.Btcero_Click);
            // 
            // Btborrarcaracter
            // 
            this.Btborrarcaracter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btborrarcaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btborrarcaracter.Location = new System.Drawing.Point(173, 265);
            this.Btborrarcaracter.Name = "Btborrarcaracter";
            this.Btborrarcaracter.Size = new System.Drawing.Size(144, 55);
            this.Btborrarcaracter.TabIndex = 18;
            this.Btborrarcaracter.Text = "BA";
            this.Btborrarcaracter.UseVisualStyleBackColor = false;
            this.Btborrarcaracter.Click += new System.EventHandler(this.Btborrarcaracter_Click);
            // 
            // Btexponente
            // 
            this.Btexponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btexponente.Location = new System.Drawing.Point(323, 214);
            this.Btexponente.Name = "Btexponente";
            this.Btexponente.Size = new System.Drawing.Size(97, 37);
            this.Btexponente.TabIndex = 19;
            this.Btexponente.Text = "^";
            this.Btexponente.UseVisualStyleBackColor = true;
            this.Btexponente.Click += new System.EventHandler(this.Btexponente_Click);
            // 
            // Btraiz
            // 
            this.Btraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btraiz.Location = new System.Drawing.Point(220, 214);
            this.Btraiz.Name = "Btraiz";
            this.Btraiz.Size = new System.Drawing.Size(97, 37);
            this.Btraiz.TabIndex = 20;
            this.Btraiz.Text = "√ ";
            this.Btraiz.UseVisualStyleBackColor = true;
            this.Btraiz.Click += new System.EventHandler(this.Btraiz_Click);
            // 
            // Btpi
            // 
            this.Btpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btpi.Location = new System.Drawing.Point(117, 214);
            this.Btpi.Name = "Btpi";
            this.Btpi.Size = new System.Drawing.Size(97, 37);
            this.Btpi.TabIndex = 21;
            this.Btpi.Text = "π";
            this.Btpi.UseVisualStyleBackColor = true;
            this.Btpi.Click += new System.EventHandler(this.Btpi_Click);
            // 
            // Btlog
            // 
            this.Btlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btlog.Location = new System.Drawing.Point(14, 214);
            this.Btlog.Name = "Btlog";
            this.Btlog.Size = new System.Drawing.Size(97, 37);
            this.Btlog.TabIndex = 22;
            this.Btlog.Text = "Log ";
            this.Btlog.UseVisualStyleBackColor = true;
            this.Btlog.Click += new System.EventHandler(this.Btlog_Click);
            // 
            // BtSen
            // 
            this.BtSen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtSen.Location = new System.Drawing.Point(14, 176);
            this.BtSen.Name = "BtSen";
            this.BtSen.Size = new System.Drawing.Size(97, 32);
            this.BtSen.TabIndex = 23;
            this.BtSen.Text = "Sen";
            this.BtSen.UseVisualStyleBackColor = true;
            this.BtSen.Click += new System.EventHandler(this.BtSen_Click);
            // 
            // BtCoseno
            // 
            this.BtCoseno.Location = new System.Drawing.Point(117, 176);
            this.BtCoseno.Name = "BtCoseno";
            this.BtCoseno.Size = new System.Drawing.Size(97, 32);
            this.BtCoseno.TabIndex = 24;
            this.BtCoseno.Text = "Cos";
            this.BtCoseno.UseVisualStyleBackColor = true;
            this.BtCoseno.Click += new System.EventHandler(this.BtCoseno_Click);
            // 
            // Btporciento
            // 
            this.Btporciento.Location = new System.Drawing.Point(220, 176);
            this.Btporciento.Name = "Btporciento";
            this.Btporciento.Size = new System.Drawing.Size(97, 32);
            this.Btporciento.TabIndex = 25;
            this.Btporciento.Text = "%";
            this.Btporciento.UseVisualStyleBackColor = true;
            this.Btporciento.Click += new System.EventHandler(this.Btporciento_Click);
            // 
            // Btguardarenmemoria
            // 
            this.Btguardarenmemoria.Location = new System.Drawing.Point(323, 176);
            this.Btguardarenmemoria.Name = "Btguardarenmemoria";
            this.Btguardarenmemoria.Size = new System.Drawing.Size(97, 32);
            this.Btguardarenmemoria.TabIndex = 26;
            this.Btguardarenmemoria.Text = "MS";
            this.Btguardarenmemoria.UseVisualStyleBackColor = true;
            this.Btguardarenmemoria.Click += new System.EventHandler(this.Btguardarenmemoria_Click);
            // 
            // Btrecuperarnumero
            // 
            this.Btrecuperarnumero.Location = new System.Drawing.Point(14, 138);
            this.Btrecuperarnumero.Name = "Btrecuperarnumero";
            this.Btrecuperarnumero.Size = new System.Drawing.Size(97, 32);
            this.Btrecuperarnumero.TabIndex = 27;
            this.Btrecuperarnumero.Text = "MR";
            this.Btrecuperarnumero.UseVisualStyleBackColor = true;
            this.Btrecuperarnumero.Click += new System.EventHandler(this.Btrecuperarnumero_Click);
            // 
            // Btlimpiar
            // 
            this.Btlimpiar.Location = new System.Drawing.Point(117, 138);
            this.Btlimpiar.Name = "Btlimpiar";
            this.Btlimpiar.Size = new System.Drawing.Size(97, 32);
            this.Btlimpiar.TabIndex = 28;
            this.Btlimpiar.Text = "MC";
            this.Btlimpiar.UseVisualStyleBackColor = true;
            this.Btlimpiar.Click += new System.EventHandler(this.Btlimpiar_Click);
            // 
            // Btrestarguardado
            // 
            this.Btrestarguardado.Location = new System.Drawing.Point(220, 138);
            this.Btrestarguardado.Name = "Btrestarguardado";
            this.Btrestarguardado.Size = new System.Drawing.Size(97, 32);
            this.Btrestarguardado.TabIndex = 29;
            this.Btrestarguardado.Text = "M-";
            this.Btrestarguardado.UseVisualStyleBackColor = true;
            this.Btrestarguardado.Click += new System.EventHandler(this.Btrestarguardado_Click);
            // 
            // Btsumarguardado
            // 
            this.Btsumarguardado.Location = new System.Drawing.Point(323, 138);
            this.Btsumarguardado.Name = "Btsumarguardado";
            this.Btsumarguardado.Size = new System.Drawing.Size(97, 32);
            this.Btsumarguardado.TabIndex = 30;
            this.Btsumarguardado.Text = "M+";
            this.Btsumarguardado.UseVisualStyleBackColor = true;
            this.Btsumarguardado.Click += new System.EventHandler(this.Btsumarguardado_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(446, 600);
            this.Controls.Add(this.Btsumarguardado);
            this.Controls.Add(this.Btrestarguardado);
            this.Controls.Add(this.Btlimpiar);
            this.Controls.Add(this.Btrecuperarnumero);
            this.Controls.Add(this.Btguardarenmemoria);
            this.Controls.Add(this.Btporciento);
            this.Controls.Add(this.BtCoseno);
            this.Controls.Add(this.BtSen);
            this.Controls.Add(this.Btlog);
            this.Controls.Add(this.Btpi);
            this.Controls.Add(this.Btraiz);
            this.Controls.Add(this.Btexponente);
            this.Controls.Add(this.Btborrarcaracter);
            this.Controls.Add(this.Btcero);
            this.Controls.Add(this.Btciete);
            this.Controls.Add(this.Btcuatro);
            this.Controls.Add(this.Btuno);
            this.Controls.Add(this.Btocho);
            this.Controls.Add(this.Btcinco);
            this.Controls.Add(this.Btdos);
            this.Controls.Add(this.Btborrarpantalla);
            this.Controls.Add(this.Btnueve);
            this.Controls.Add(this.Btseis);
            this.Controls.Add(this.Bttres);
            this.Controls.Add(this.Btpunto);
            this.Controls.Add(this.Btdividir);
            this.Controls.Add(this.Btmultiplicacion);
            this.Controls.Add(this.Btresta);
            this.Controls.Add(this.Btsuma);
            this.Controls.Add(this.Btigual);
            this.Controls.Add(this.txtPantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button Btigual;
        private System.Windows.Forms.Button Btsuma;
        private System.Windows.Forms.Button Btmultiplicacion;
        private System.Windows.Forms.Button Btresta;
        private System.Windows.Forms.Button Btdividir;
        private System.Windows.Forms.Button Btborrarpantalla;
        private System.Windows.Forms.Button Btnueve;
        private System.Windows.Forms.Button Btseis;
        private System.Windows.Forms.Button Bttres;
        private System.Windows.Forms.Button Btpunto;
        private System.Windows.Forms.Button Btocho;
        private System.Windows.Forms.Button Btcinco;
        private System.Windows.Forms.Button Btdos;
        private System.Windows.Forms.Button Btciete;
        private System.Windows.Forms.Button Btcuatro;
        private System.Windows.Forms.Button Btuno;
        private System.Windows.Forms.Button Btcero;
        private System.Windows.Forms.Button Btborrarcaracter;
        private System.Windows.Forms.Button Btexponente;
        private System.Windows.Forms.Button Btraiz;
        private System.Windows.Forms.Button Btpi;
        private System.Windows.Forms.Button Btlog;
        private System.Windows.Forms.Button BtSen;
        private System.Windows.Forms.Button BtCoseno;
        private System.Windows.Forms.Button Btporciento;
        private System.Windows.Forms.Button Btguardarenmemoria;
        private System.Windows.Forms.Button Btrecuperarnumero;
        private System.Windows.Forms.Button Btlimpiar;
        private System.Windows.Forms.Button Btrestarguardado;
        private System.Windows.Forms.Button Btsumarguardado;
    }
}

