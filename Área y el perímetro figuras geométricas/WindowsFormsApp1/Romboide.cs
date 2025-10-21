﻿using System;
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
    public partial class Romboide : Form
    {
        public Romboide()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            try
            {
                int numero1 = int.Parse(txtLado1.Text);
                int numero2 = int.Parse(txtLado2.Text);
                if (numero1 <= 0 || numero2 <= 0)
                {
                    MessageBox.Show("El lado no puede ser 0 ser negativo");

                }
                else
                {
                    int resultado = (numero1 * numero2);
                    MessageBox.Show("El area del romboide es: " + resultado.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }
    }
}
