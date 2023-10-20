using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            InitializeComponent();
            CargarDatos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string busqueda = inputBusqueda.Text;

            string selectQuery = "SELECT * FROM Alumnos WHERE nombre = @busqueda";

            string connectionString = "Data Source=InstitutoBepinho.db;Version=3;";

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
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
        private void CargarDatos()
        {
            string connectionString = "Data Source=InstitutoBepinho.db;Version=3;";

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
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
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

                    string idAlumno = selectedRow.Cells["idAlumno"].Value.ToString();
                    string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                    string apellido = selectedRow.Cells["Apellido"].Value.ToString();
                    string matricula = selectedRow.Cells["Matricula"].Value.ToString();
                    string edad = selectedRow.Cells["Edad"].Value.ToString();
                    string email = selectedRow.Cells["Email"].Value.ToString();
                    string carrera = selectedRow.Cells["Carrera"].Value.ToString();
                    string connectionString = "Data Source=InstitutoBepinho.db;Version=3;";
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string updateQuery = "UPDATE Alumnos SET Nombre = @nombre, Apellido = @apellido, Matricula = @matricula, Edad = @edad, Email = @email, Carrera = @carrera WHERE idAlumno = @idAlumno";

                        using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@apellido", apellido);
                            command.Parameters.AddWithValue("@matricula", matricula);
                            command.Parameters.AddWithValue("@edad", edad);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@carrera", carrera);
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
                MessageBox.Show("Seleccione una fila para modificar.");
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
                string connectionString = "Data Source=InstitutoBepinho.db;Version=3;";

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
                    string connectionString = "Data Source=InstitutoBepinho.db;Version=3;";

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
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

    }
}

