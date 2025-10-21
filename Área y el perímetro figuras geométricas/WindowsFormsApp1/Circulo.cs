using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void btnCalcularCirculo_Click(object sender, EventArgs e)
        {
            
            try
            {
                double numero1 = double.Parse(txtRadio.Text);
                double pi = 3.1416;
                if (numero1 <= 0)
                {
                    MessageBox.Show("El radio no puede ser 0 negativo");

                }
                else
                {
                    double resultado = pi * (numero1*numero1);
                    MessageBox.Show("El area del circulo es: " + resultado.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }
    }
}
