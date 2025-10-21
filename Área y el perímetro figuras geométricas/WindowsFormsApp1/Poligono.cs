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
    public partial class Poligono : Form
    {
        public Poligono()
        {
            InitializeComponent();
        }

        private void btnCalcularPoligono_Click(object sender, EventArgs e)
        {
            
            try
            {
                int numero1 = int.Parse(txtPerimetro.Text);
                int numero2 = int.Parse(txtApotema.Text);
                if (numero1 <= 0 || numero2 <= 0)
                {
                    MessageBox.Show("El perimetro o apotema no puede ser 0 ser negativo");

                }
                else
                {
                    int resultado = (numero1 * numero2) / 2;
                    MessageBox.Show("El area del poligono es: " + resultado.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }
    }
}
