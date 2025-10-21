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
    public partial class Trapecio : Form
    {
        public Trapecio()
        {
            InitializeComponent();
        }

        private void btnCalcularTrapecio_Click(object sender, EventArgs e)
        {
            
            try
            {
                int numero1 = int.Parse(txtBaseMayor.Text);
                int numero2 = int.Parse(txtBaseMenor.Text);
                int numero3 = int.Parse(txtAltura.Text);
                if (numero1 <= 0 || numero2 <= 0||numero3<=0)
                {
                    MessageBox.Show("La base o altura no puede ser 0 ser negativo");

                }
                else
                {
                    int resultado = (numero3*(numero1 * numero2))/2;
                    MessageBox.Show("El area del trapecio es: " + resultado.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }
    }
}
