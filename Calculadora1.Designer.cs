namespace Calculadora
{
    partial class Calculadora1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSuma = new Button();
            label1 = new Label();
            Pantalla = new TextBox();
            btnResta = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            btnSiete = new Button();
            btnOcho = new Button();
            btnNueve = new Button();
            btnAC = new Button();
            btnDEL = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnTres = new Button();
            btnDos = new Button();
            btnUno = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.FromArgb(192, 192, 255);
            btnSuma.Font = new Font("Segoe UI", 18F);
            btnSuma.Location = new Point(19, 158);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(45, 41);
            btnSuma.TabIndex = 0;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 32);
            label1.Name = "label1";
            label1.Size = new Size(160, 27);
            label1.TabIndex = 1;
            label1.Text = "Calculadora ";
            // 
            // Pantalla
            // 
            Pantalla.BackColor = SystemColors.GradientActiveCaption;
            Pantalla.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pantalla.Location = new Point(12, 76);
            Pantalla.Multiline = true;
            Pantalla.Name = "Pantalla";
            Pantalla.Size = new Size(255, 70);
            Pantalla.TabIndex = 2;
            Pantalla.Text = "operacion\r\nresultado";
            Pantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.FromArgb(192, 192, 255);
            btnResta.Font = new Font("Segoe UI", 18F);
            btnResta.Location = new Point(81, 158);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(45, 41);
            btnResta.TabIndex = 21;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.BackColor = Color.FromArgb(192, 192, 255);
            btnMultiplicacion.Font = new Font("Segoe UI", 18F);
            btnMultiplicacion.Location = new Point(144, 158);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(45, 41);
            btnMultiplicacion.TabIndex = 22;
            btnMultiplicacion.Text = "x";
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.FromArgb(192, 192, 255);
            btnDivision.Font = new Font("Segoe UI", 18F);
            btnDivision.Location = new Point(208, 158);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(45, 41);
            btnDivision.TabIndex = 23;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = SystemColors.ScrollBar;
            btnSiete.Font = new Font("Segoe UI", 18F);
            btnSiete.Location = new Point(19, 203);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(45, 41);
            btnSiete.TabIndex = 24;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += btnSiete_Click;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = SystemColors.ScrollBar;
            btnOcho.Font = new Font("Segoe UI", 18F);
            btnOcho.Location = new Point(81, 204);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(45, 41);
            btnOcho.TabIndex = 25;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += btnOcho_Click;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = SystemColors.ScrollBar;
            btnNueve.Font = new Font("Segoe UI", 18F);
            btnNueve.Location = new Point(144, 203);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(45, 41);
            btnNueve.TabIndex = 26;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += btnNueve_Click;
            // 
            // btnAC
            // 
            btnAC.BackColor = Color.FromArgb(255, 128, 128);
            btnAC.Font = new Font("Segoe UI", 10F);
            btnAC.Location = new Point(208, 203);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(45, 41);
            btnAC.TabIndex = 27;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += btnAC_Click;
            // 
            // btnDEL
            // 
            btnDEL.BackColor = Color.FromArgb(255, 128, 128);
            btnDEL.Font = new Font("Segoe UI", 10F);
            btnDEL.Location = new Point(208, 249);
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(45, 41);
            btnDEL.TabIndex = 31;
            btnDEL.Text = "DEL";
            btnDEL.UseVisualStyleBackColor = false;
            btnDEL.Click += btnDEL_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = SystemColors.ScrollBar;
            btnSeis.Font = new Font("Segoe UI", 18F);
            btnSeis.Location = new Point(144, 249);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(45, 41);
            btnSeis.TabIndex = 30;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = SystemColors.ScrollBar;
            btnCinco.Font = new Font("Segoe UI", 18F);
            btnCinco.Location = new Point(80, 249);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(45, 41);
            btnCinco.TabIndex = 29;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnCuatro
            // 
            btnCuatro.BackColor = SystemColors.ScrollBar;
            btnCuatro.Font = new Font("Segoe UI", 18F);
            btnCuatro.Location = new Point(19, 249);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(45, 41);
            btnCuatro.TabIndex = 28;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = false;
            btnCuatro.Click += btnCuatro_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.ScrollBar;
            btnTres.Font = new Font("Segoe UI", 18F);
            btnTres.Location = new Point(144, 296);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(45, 41);
            btnTres.TabIndex = 34;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnDos
            // 
            btnDos.BackColor = SystemColors.ScrollBar;
            btnDos.Font = new Font("Segoe UI", 18F);
            btnDos.Location = new Point(80, 296);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(45, 41);
            btnDos.TabIndex = 33;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += btnDos_Click;
            // 
            // btnUno
            // 
            btnUno.BackColor = SystemColors.ScrollBar;
            btnUno.Font = new Font("Segoe UI", 18F);
            btnUno.Location = new Point(19, 296);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(45, 41);
            btnUno.TabIndex = 32;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += btnUno_Click;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = SystemColors.ScrollBar;
            btnPunto.Font = new Font("Segoe UI", 18F);
            btnPunto.Location = new Point(144, 343);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(45, 41);
            btnPunto.TabIndex = 36;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.BackColor = SystemColors.ScrollBar;
            btnCero.Font = new Font("Segoe UI", 18F);
            btnCero.Location = new Point(19, 343);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(106, 41);
            btnCero.TabIndex = 35;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += btnCero_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.Khaki;
            btnIgual.Font = new Font("Segoe UI", 25F);
            btnIgual.Location = new Point(208, 296);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(45, 88);
            btnIgual.TabIndex = 38;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // Calculadora1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 399);
            Controls.Add(btnIgual);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(btnDEL);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnAC);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnResta);
            Controls.Add(Pantalla);
            Controls.Add(label1);
            Controls.Add(btnSuma);
            Name = "Calculadora1";
            Text = "Calcu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuma;
        private Label label1;
        private TextBox Pantalla;
        private Button btnResta;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private Button btnSiete;
        private Button btnOcho;
        private Button btnNueve;
        private Button btnAC;
        private Button btnDEL;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnTres;
        private Button btnDos;
        private Button btnUno;
        private Button btnPunto;
        private Button btnCero;
        private Button btnIgual;
    }
}
