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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                if (int.TryParse(txtNum.Text, out int numero))
                {

                    if (numero < 50)
                    {
                        //cambia el color a rojo
                        this.BackColor = Color.Red;
                    }
                    else if (numero > 50)
                    {
                        //cambia el color a negro
                        this.BackColor = Color.Black;

                    }
                    else if (numero == 50)
                    {
                        //cambia el color a verde
                        this.BackColor = Color.Green;

                    }
                }
            }
        }
    }
}
