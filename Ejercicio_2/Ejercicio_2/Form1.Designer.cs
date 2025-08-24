namespace Ejercicio_2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cantaltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cantpeso = new System.Windows.Forms.TextBox();
            this.lbPeso = new System.Windows.Forms.Label();
            this.btMedir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.Contador = new System.Windows.Forms.Label();
            this.Btcontarclick = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Btborrar = new System.Windows.Forms.Button();
            this.BtConvertir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GradosF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GradosC = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cantaltura);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cantpeso);
            this.tabPage1.Controls.Add(this.lbPeso);
            this.tabPage1.Controls.Add(this.btMedir);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IMC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Indice de masa corporal\r\n";
            // 
            // cantaltura
            // 
            this.cantaltura.Location = new System.Drawing.Point(295, 153);
            this.cantaltura.Name = "cantaltura";
            this.cantaltura.Size = new System.Drawing.Size(217, 26);
            this.cantaltura.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "altura (0.00 m)";
            // 
            // cantpeso
            // 
            this.cantpeso.Location = new System.Drawing.Point(295, 89);
            this.cantpeso.Name = "cantpeso";
            this.cantpeso.Size = new System.Drawing.Size(217, 26);
            this.cantpeso.TabIndex = 2;
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(188, 95);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(87, 20);
            this.lbPeso.TabIndex = 1;
            this.lbPeso.Text = "peso en kg";
            // 
            // btMedir
            // 
            this.btMedir.Location = new System.Drawing.Point(329, 232);
            this.btMedir.Name = "btMedir";
            this.btMedir.Size = new System.Drawing.Size(136, 30);
            this.btMedir.TabIndex = 0;
            this.btMedir.Text = "Medir\r\n";
            this.btMedir.UseVisualStyleBackColor = true;
            this.btMedir.Click += new System.EventHandler(this.btMedir_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Contador);
            this.tabPage2.Controls.Add(this.Btcontarclick);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contador de clicks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(130, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contador de click";
            // 
            // Contador
            // 
            this.Contador.AutoSize = true;
            this.Contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Contador.Location = new System.Drawing.Point(448, 104);
            this.Contador.Name = "Contador";
            this.Contador.Size = new System.Drawing.Size(75, 82);
            this.Contador.TabIndex = 1;
            this.Contador.Text = "0";
            // 
            // Btcontarclick
            // 
            this.Btcontarclick.BackColor = System.Drawing.Color.Firebrick;
            this.Btcontarclick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btcontarclick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btcontarclick.Location = new System.Drawing.Point(118, 147);
            this.Btcontarclick.Name = "Btcontarclick";
            this.Btcontarclick.Size = new System.Drawing.Size(165, 105);
            this.Btcontarclick.TabIndex = 0;
            this.Btcontarclick.Text = "CLICK";
            this.Btcontarclick.UseVisualStyleBackColor = false;
            this.Btcontarclick.Click += new System.EventHandler(this.Btcontarclick_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Btborrar);
            this.tabPage3.Controls.Add(this.BtConvertir);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.GradosF);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.GradosC);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conversor de temperaturas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Btborrar
            // 
            this.Btborrar.Location = new System.Drawing.Point(421, 239);
            this.Btborrar.Name = "Btborrar";
            this.Btborrar.Size = new System.Drawing.Size(116, 39);
            this.Btborrar.TabIndex = 5;
            this.Btborrar.Text = "Borrar";
            this.Btborrar.UseVisualStyleBackColor = true;
            this.Btborrar.Click += new System.EventHandler(this.Btborrar_Click);
            // 
            // BtConvertir
            // 
            this.BtConvertir.Location = new System.Drawing.Point(273, 239);
            this.BtConvertir.Name = "BtConvertir";
            this.BtConvertir.Size = new System.Drawing.Size(116, 39);
            this.BtConvertir.TabIndex = 4;
            this.BtConvertir.Text = "Convertir";
            this.BtConvertir.UseVisualStyleBackColor = true;
            this.BtConvertir.Click += new System.EventHandler(this.BtConvertir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grados Fahrenheit";
            // 
            // GradosF
            // 
            this.GradosF.Location = new System.Drawing.Point(273, 153);
            this.GradosF.Name = "GradosF";
            this.GradosF.Size = new System.Drawing.Size(264, 26);
            this.GradosF.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grados celcius";
            // 
            // GradosC
            // 
            this.GradosC.Location = new System.Drawing.Point(273, 88);
            this.GradosC.Name = "GradosC";
            this.GradosC.Size = new System.Drawing.Size(264, 26);
            this.GradosC.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox cantpeso;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Button btMedir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantaltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GradosC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GradosF;
        private System.Windows.Forms.Button BtConvertir;
        private System.Windows.Forms.Button Btborrar;
        private System.Windows.Forms.Label Contador;
        private System.Windows.Forms.Button Btcontarclick;
        private System.Windows.Forms.Label label6;
    }
}

