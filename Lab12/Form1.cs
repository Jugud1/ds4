using System;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Intentamos realizar el cálculo
            try
            {
                // Obtener los valores de velocidad y tiempo
                double velocidad = double.Parse(txtVelocidad.Text);
                double tiempo = double.Parse(txtTiempo.Text);

                // Calcular la distancia
                double resultado = velocidad * tiempo;

                // Mostrar el resultado
                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para velocidad y tiempo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto
            txtVelocidad.Clear();
            txtTiempo.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            this.Close();
        }

        private void txtVelocidad_TextChanged(object sender, EventArgs e) { }

        private void txtTiempo_TextChanged(object sender, EventArgs e) { }

        private void txtResultado_TextChanged(object sender, EventArgs e) { }
    }
}