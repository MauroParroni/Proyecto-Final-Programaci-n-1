namespace Proyecto_final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            inputNombre = new TextBox();
            inputApellido = new TextBox();
            label2 = new Label();
            inputMatricula = new TextBox();
            label3 = new Label();
            inputEdad = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            inputEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxCarrera = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 65);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(26, 88);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(220, 27);
            inputNombre.TabIndex = 1;
            // 
            // inputApellido
            // 
            inputApellido.Location = new Point(26, 142);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(220, 27);
            inputApellido.TabIndex = 3;
            inputApellido.TextChanged += inputApellido_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 119);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // inputMatricula
            // 
            inputMatricula.Location = new Point(26, 195);
            inputMatricula.Name = "inputMatricula";
            inputMatricula.Size = new Size(220, 27);
            inputMatricula.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 172);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "Nro Matricula";
            // 
            // inputEdad
            // 
            inputEdad.Location = new Point(26, 248);
            inputEdad.Name = "inputEdad";
            inputEdad.Size = new Size(220, 27);
            inputEdad.TabIndex = 7;
            inputEdad.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 225);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 6;
            label4.Text = "Edad";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(303, 394);
            button1.Name = "button1";
            button1.Size = new Size(187, 35);
            button1.TabIndex = 8;
            button1.Text = "Inscribir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(580, 290);
            button2.Name = "button2";
            button2.Size = new Size(168, 71);
            button2.TabIndex = 9;
            button2.Text = "Panel de Control";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(551, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(26, 303);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(220, 27);
            inputEmail.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 280);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 333);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 13;
            label6.Text = "Carrera";
            label6.Click += label6_Click;
            // 
            // comboBoxCarrera
            // 
            comboBoxCarrera.FormattingEnabled = true;
            comboBoxCarrera.Items.AddRange(new object[] { "TECNICO SUPERIOR EN DESARROLLO DE SOFTWARE", "ANALISTA EN MEDIO AMBIENTE", "TECNICO SUPERIOR EN COMERCIO EXTERIOR", "COMERCIALIZACION Y ADMINISTRACION DE EMPRESAS", "TECNICO SUPERIOR EN HIGIENE Y SEGURIDAD", "ANALISTA EN SISTEMAS DE CONTROL", "ANALISTA EN MICROELECTRONICA", "QUIMICO SUPERIOR INDUSTRIAL", "QUIMICO SUPERIOR ANALISTA" });
            comboBoxCarrera.Location = new Point(26, 356);
            comboBoxCarrera.Name = "comboBoxCarrera";
            comboBoxCarrera.Size = new Size(220, 28);
            comboBoxCarrera.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(321, 9);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 16;
            label7.Text = "Instituto Beppo Levi";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 22);
            label8.Name = "label8";
            label8.Size = new Size(155, 20);
            label8.TabIndex = 17;
            label8.Text = "Inscripcion a alumnos:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBoxCarrera);
            Controls.Add(label6);
            Controls.Add(inputEmail);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(inputEdad);
            Controls.Add(label4);
            Controls.Add(inputMatricula);
            Controls.Add(label3);
            Controls.Add(inputApellido);
            Controls.Add(label2);
            Controls.Add(inputNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputNombre;
        private TextBox inputApellido;
        private Label label2;
        private TextBox inputMatricula;
        private Label label3;
        private TextBox inputEdad;
        private Label label4;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox inputEmail;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxCarrera;
        private Label label7;
        private Label label8;
    }
}