﻿using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.Data.SQLite;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int countdown = 10;
        public Form2()
        {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            InitializeComponent();
            this.Text = "Tabla Dudosa";
            this.Icon = new Icon(@"C:\Users\Locazin\source\repos\WinFormsApp1\Proyecto final\images\favicon.ico"); //funciona solo localmente xd
            CargarDatos();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string busqueda = inputBusqueda.Text;

            if (string.IsNullOrEmpty(busqueda))
            {
                CargarDatos();
                return;
            }

            string selectQuery = "SELECT * FROM Alumnos WHERE nombre LIKE '%' || @busqueda || '%' OR apellido LIKE '%' || @busqueda || '%'";

            string connectionString = "Data Source=InstitutoBepinho3.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@busqueda", busqueda);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron usuarios con ese nombre/apellido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                        else
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
        }


        private void CargarDatos()
        {
            string connectionString = "Data Source=InstitutoBepinho3.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Alumnos";

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable tablaAlumnos = new DataTable();
                        adapter.Fill(tablaAlumnos);
                        dataGridView1.DataSource = tablaAlumnos;
                        dataGridView1.Columns["Carrera"].ReadOnly = true;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool esvalido(string valor)
        {
            string pattern = @"^[a-zA-Z]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(valor, pattern);
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas modificar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];
                    string patternyear = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$";
                    string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                    string idAlumno = selectedRow.Cells["idAlumno"].Value.ToString();
                    string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                    string apellido = selectedRow.Cells["Apellido"].Value.ToString();
                    string matricula = selectedRow.Cells["DNI"].Value.ToString();
                    string edad = selectedRow.Cells["fecha_nac"].Value.ToString();
                    string email = selectedRow.Cells["Email"].Value.ToString();
                    if (int.TryParse(matricula, out int valor))
                    {
                        if (valor < 100000000 && valor > 5000000)
                        {

                        }
                        else
                        {
                            MessageBox.Show(" Ingrese un dni valido");
                            CargarDatos();
                            return;

                        }

                    }
                    else
                    {
                        MessageBox.Show(" Ingrese un dni valido");
                        CargarDatos();
                        return;

                    }

                    if (Regex.IsMatch(email, pattern))
                    {
                    }
                    else
                    {
                        MessageBox.Show(" Ingrese un correo valido");
                        CargarDatos();
                        return;

                    }
                    if (Regex.IsMatch(edad, patternyear))
                    {
                        string[] dateParts = edad.Split('/');
                        int year = Convert.ToInt32(dateParts[2]);
                        if (year > 2005)
                        {
                            MessageBox.Show("Ingrese una fecha valida");
                            CargarDatos();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Ingrese una fecha valida");
                        CargarDatos();
                        return;
                    }
                    if (!esvalido(nombre) || !esvalido(apellido))
                    {
                        MessageBox.Show("ingrese un valor valido");
                        CargarDatos();
                        return;
                    }
                    string connectionString = "Data Source=InstitutoBepinho3.db;Version=3;";
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string updateQuery = "UPDATE Alumnos SET Nombre = @nombre, Apellido = @apellido, DNI = @matricula, fecha_nac = @edad, Email = @email WHERE idAlumno = @idAlumno";

                        using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@apellido", apellido);
                            command.Parameters.AddWithValue("@matricula", matricula);
                            command.Parameters.AddWithValue("@edad", edad);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@idAlumno", idAlumno);

                            command.ExecuteNonQuery();
                        }
                    }

                    CargarDatos();
                    MessageBox.Show("Fila modificada con éxito.");
                }


            }
            else
            {
                MessageBox.Show(" Por favor realize los cambios, seleccione la fila y vuelva a presionar.");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "Alumnos.xlsx";
            saveFileDialog.Title = "Guardar archivo de Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string excelFileName = saveFileDialog.FileName;
                string connectionString = "Data Source=InstitutoBepinho3.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Alumnos";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            using (ExcelPackage excelPackage = new ExcelPackage())
                            {
                                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add("Alumnos");

                                // Poner en el excel los datos de la tabla
                                excelWorksheet.Cells.LoadFromDataTable(dataTable, true);
                                // Personalizar el formato
                                excelWorksheet.Cells.AutoFitColumns();
                                excelWorksheet.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                                // Guardar el archivo en la ubicación seleccionada por el user
                                System.IO.FileInfo excelFile = new System.IO.FileInfo(excelFileName);
                                excelPackage.SaveAs(excelFile);

                                MessageBox.Show("Los datos se han descargado en " + excelFile.FullName);
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string idAlumno = dataGridView1.Rows[selectedIndex].Cells["idAlumno"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = "Data Source=InstitutoBepinho3.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Alumnos WHERE idAlumno = @idAlumno";

                        using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@idAlumno", idAlumno);
                            command.ExecuteNonQuery();
                        }
                    }

                    CargarDatos();
                    MessageBox.Show("Fila eliminada con éxito.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para dar de baja un alumno.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string carreraSeleccionada = comboBoxCarrera.SelectedItem?.ToString();

            string selectQuery = "SELECT * FROM Alumnos WHERE Carrera = @carrera";

            if (carreraSeleccionada == "TODAS")
            {
                CargarDatos();
                return;
            }

            string connectionString = "Data Source=InstitutoBepinho3.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@carrera", carreraSeleccionada);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron usuarios con esta Carrera", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                        else
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1-Para modificar la carrera de alguno de los alumnos debe eliminar por completo al alumno y volverlo a cargar(esto se solucionara en la 1.14.2)");
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label4.Visible = true;
            countdown--;
            if (countdown > 0)
            {
                label4.Text = $"Por curioso en {countdown} segundos, saldrá un screamer";
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Te la creiste we");
                label4.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


    }
}

