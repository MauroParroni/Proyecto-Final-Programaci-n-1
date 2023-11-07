namespace Proyecto_final
{
    partial class Form2
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
            button1 = new Button();
            inputBusqueda = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            label1 = new Label();
            comboBoxCarrera = new ComboBox();
            label2 = new Label();
            button6 = new Button();
            label3 = new Label();
            button7 = new Button();
            button8 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1253, 248);
            button1.Name = "button1";
            button1.Size = new Size(132, 27);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inputBusqueda
            // 
            inputBusqueda.Location = new Point(1161, 215);
            inputBusqueda.Name = "inputBusqueda";
            inputBusqueda.PlaceholderText = "Ingrese nombre o apellido del alumno";
            inputBusqueda.Size = new Size(321, 27);
            inputBusqueda.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(1253, 366);
            button2.Name = "button2";
            button2.Size = new Size(132, 31);
            button2.TabIndex = 2;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1253, 403);
            button3.Name = "button3";
            button3.Size = new Size(132, 31);
            button3.TabIndex = 3;
            button3.Text = "Dar baja";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1253, 440);
            button4.Name = "button4";
            button4.Size = new Size(132, 31);
            button4.TabIndex = 4;
            button4.Text = "Descargar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1079, 501);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(14, 3);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.Yes;
            button5.Size = new Size(185, 69);
            button5.TabIndex = 6;
            button5.Text = "Atras";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1179, 184);
            label1.Name = "label1";
            label1.Size = new Size(292, 28);
            label1.TabIndex = 7;
            label1.Text = "Buscar por nombre o apellido";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxCarrera
            // 
            comboBoxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCarrera.FormattingEnabled = true;
            comboBoxCarrera.Items.AddRange(new object[] { "TODAS", "TECNICO SUPERIOR EN DESARROLLO DE SOFTWARE", "ANALISTA EN MEDIO AMBIENTE", "TECNICO SUPERIOR EN COMERCIO EXTERIOR", "COMERCIALIZACION Y ADMINISTRACION DE EMPRESAS", "TECNICO SUPERIOR EN HIGIENE Y SEGURIDAD", "ANALISTA EN SISTEMAS DE CONTROL", "ANALISTA EN MICROELECTRONICA", "QUIMICO SUPERIOR INDUSTRIAL", "QUIMICO SUPERIOR ANALISTA" });
            comboBoxCarrera.Location = new Point(1129, 44);
            comboBoxCarrera.Name = "comboBoxCarrera";
            comboBoxCarrera.Size = new Size(378, 28);
            comboBoxCarrera.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1226, 9);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 9;
            label2.Text = "Filtro por carreras:";
            label2.Click += label2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1253, 78);
            button6.Name = "button6";
            button6.Size = new Size(132, 29);
            button6.TabIndex = 10;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(286, 5);
            label3.MaximumSize = new Size(3000, 0);
            label3.Name = "label3";
            label3.Size = new Size(712, 67);
            label3.TabIndex = 11;
            label3.Text = "El instituto beppo levi no se hace cargo de los datos cargados en este formulario, todo lo que usted cargue sera bajo su responsabilidad. Queda avisado.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1330, 535);
            button7.Name = "button7";
            button7.Size = new Size(190, 56);
            button7.TabIndex = 12;
            button7.Text = "Ayuda";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(1114, 535);
            button8.Name = "button8";
            button8.Size = new Size(95, 56);
            button8.TabIndex = 13;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(309, 248);
            label4.Name = "label4";
            label4.Size = new Size(818, 50);
            label4.TabIndex = 14;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 591);
            Controls.Add(label4);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(comboBoxCarrera);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(inputBusqueda);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox inputBusqueda;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
        private Label label1;
        private ComboBox comboBoxCarrera;
        private Label label2;
        private Button button6;
        private Label label3;
        private Button button7;
        private Button button8;
        private Label label4;
    }
}