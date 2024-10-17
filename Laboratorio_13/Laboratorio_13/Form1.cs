using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio_13
{
    public partial class Form1 : Form

    {
        string connectionString =
            @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        public Form1()
        {
           
            InitializeComponent();
        }

        
        private void btnHit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limpiar el ListBox antes de llenarlo

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT ProductName FROM [dbo].[Products]";
                    SqlCommand command = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["ProductName"].ToString());
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
