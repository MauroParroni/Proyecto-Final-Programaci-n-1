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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 14);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inputBusqueda
            // 
            inputBusqueda.Location = new Point(179, 16);
            inputBusqueda.Name = "inputBusqueda";
            inputBusqueda.PlaceholderText = "Ingrese nombre del alumno";
            inputBusqueda.Size = new Size(238, 27);
            inputBusqueda.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(454, 18);
            button2.Name = "button2";
            button2.Size = new Size(129, 28);
            button2.TabIndex = 2;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(667, 16);
            button3.Name = "button3";
            button3.Size = new Size(135, 30);
            button3.TabIndex = 3;
            button3.Text = "Dar baja";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(898, 15);
            button4.Name = "button4";
            button4.Size = new Size(116, 31);
            button4.TabIndex = 4;
            button4.Text = "Descargar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1000, 379);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 450);
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
    }
}