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
    public partial class Rectangulo : Form
    {
        public Rectangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = int.Parse(txtLado1.Text);
                int numero2 = int.Parse(txtLado2.Text);

                if (numero1 == numero2)
                {
                    lblResultado.BackColor = Color.Red;
                    lblResultado.Text = "Los lados no pueden ser iguales";
                }
                else if (numero1 <= 0 || numero2 <= 0)
                {
                    lblResultado.BackColor = Color.Red;
                    lblResultado.Text = "El lado no puede ser 0 o negativo";
                }
                else
                {
                    lblResultado.BackColor = Color.Green;
                    int resultado = numero1 * numero2;
                    lblResultado.Text = "El area del rectangulo es: " + resultado.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos");
            }
              
        }
    }
}
