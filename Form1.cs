    using Microsoft.Extensions.FileSystemGlobbing.Internal;
    using System;
    using System.Data;
    using System.Data.SQLite;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    namespace Proyecto_final
    {
        public partial class Form1 : Form
        {
            public Form1()
            {

                InitializeComponent();
            this.Text = "Formulario Dudoso";
             this.Icon = new Icon(@"C:\Users\Locazin\source\repos\WinFormsApp1\Proyecto final\images\favicon.ico"); //funciona solo localmente xd
            

        }
        private bool verificadatos()
            {
                string connectionString = "Data Source=InstitutoBepinho3.db;Version=3;";
                string Matricula = inputMatricula.Text;

                if (!esdnivalido(Matricula))
                {
                    MessageBox.Show("Ingrese un DNI válido");
                    return false;
                }

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Alumnos WHERE DNI = @Matricula";

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Matricula", Matricula);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Ya existe un usuario con este DNI.");
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {
            }
            private bool esvalido(string valor)
            {
                string pattern = @"^[a-zA-Z]+$";
                return System.Text.RegularExpressions.Regex.IsMatch(valor, pattern);
            }
            private bool esdnivalido(string dni)
            {
                if (int.TryParse(dni, out int valor))
                {
                    int dnilenght = dni.Length;
                    return dnilenght == 7 || dnilenght == 8;
                }
                return false;
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                string patternyear = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$";
                string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                string nombre = inputNombre.Text;
                string apellido = inputApellido.Text;
                string Matricula = inputMatricula.Text;
                string edad = inputEdad.Text;
                string email = inputEmail.Text;
                string carrera = comboBoxCarrera.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(carrera))
                {
                    MessageBox.Show("Por favor, seleccione una carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!esvalido(nombre) || !esvalido(apellido))
                {
                    MessageBox.Show("ingrese un valor valido");
                    return;
                }
                if (Regex.IsMatch(email, pattern))
                {
                }
                else
                {
                    MessageBox.Show(" Ingrese un correo valido");
                    return;
                }
                if (Regex.IsMatch(edad, patternyear))
                {
                    string[] dateParts = edad.Split('/');
                    int year = Convert.ToInt32(dateParts[2]);
                    if (year > 2005 && year < 1965)
                    {
                        Console.WriteLine("Ingrese una fecha valida");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(" Ingrese una fecha valida");
                    return;
                }

                if (verificadatos())
                {


                    string connectionString = "Data Source=InstitutoBepinho3.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string createTableQuery = "CREATE TABLE IF NOT EXISTS Alumnos (idAlumno INTEGER PRIMARY KEY AUTOINCREMENT, Nombre TEXT, Apellido TEXT, DNI INTEGER, fecha_nac TEXT, Email TEXT, Carrera TEXT)";
                        using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                        {
                            createTableCommand.ExecuteNonQuery();
                        }

                        string insertQuery = "INSERT INTO Alumnos (nombre, apellido, DNI, fecha_nac, email, carrera) VALUES (@nombre, @apellido, @Matricula, @edad, @email, @carrera)";
                        using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@nombre", nombre);
                            insertCommand.Parameters.AddWithValue("@apellido", apellido);
                            insertCommand.Parameters.AddWithValue("@Matricula", Matricula);
                            insertCommand.Parameters.AddWithValue("@edad", edad);
                            insertCommand.Parameters.AddWithValue("@email", email);
                            insertCommand.Parameters.AddWithValue("@carrera", carrera);
                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos del alumno guardados.");
                    inputEdad.Text = "";
                    inputEmail.Text = "";
                    inputMatricula.Text = "";
                    inputNombre.Text = "";
                    inputApellido.Text = "";
                    comboBoxCarrera.SelectedIndex = -1;
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }

            private void label6_Click(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {
            }

            private void inputApellido_TextChanged(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }
