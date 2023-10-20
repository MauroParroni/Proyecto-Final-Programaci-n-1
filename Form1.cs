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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string nombre = inputNombre.Text;
            string apellido = inputApellido.Text;
            int Matricula;
            int edad;
            string email = inputEmail.Text;
            string carrera = comboBoxCarrera.SelectedItem.ToString();
            if (Regex.IsMatch(email, pattern))
            {
            }
            else
            {
                MessageBox.Show(" Ingrese un correo valido");
                return;
            }
            if (!int.TryParse(inputMatricula.Text, out Matricula))
            {
                MessageBox.Show(" Matricula debe ser un número entero válido.");
                return;
            }
            if (!int.TryParse(inputEdad.Text, out edad))
            {
                MessageBox.Show("Edad debe ser un número entero válido.");
                return;
            }
            if (edad > 99)
            {
                MessageBox.Show("Ingrese una edad permitida");
                return;
            }


            string connectionString = "Data Source=InstitutoBepinho.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Alumnos (idAlumno INTEGER PRIMARY KEY AUTOINCREMENT, Nombre TEXT, Apellido TEXT, Matricula INTEGER, edad INTEGER, Email TEXT, Carrera TEXT)";
                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

                string insertQuery = "INSERT INTO Alumnos (nombre, apellido, Matricula, edad, email, carrera) VALUES (@nombre, @apellido, @Matricula, @edad, @email, @carrera)";
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

            MessageBox.Show("Datos guardados en la base de datos.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
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
    }
}
