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
    public partial class Cuadrado : Form
    {
        public Cuadrado()
        {
            InitializeComponent();
        }

        private void lblLado2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = int.Parse(txtLado1.Text);
                if (numero1 <= 0)
                {
                    MessageBox.Show("El lado no puede ser 0 ser negativo");

                }
                else
                {
                    int resultado = numero1 * numero1;
                    MessageBox.Show("El area del cuadrado es: " + resultado.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }
    }
}
