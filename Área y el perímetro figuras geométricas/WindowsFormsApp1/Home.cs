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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Helper: cierra las ventanas hijas y abre la nueva en una posición fija
        private void OpenSingleChild(Form child, Point location)
        {
            // Cierra todas las ventanas hijas abiertas
            foreach (var f in this.MdiChildren)
            {
                f.Close();
            }

            // Forzar uso de coordenadas manuales y colocar la ventana en la posición deseada
            child.StartPosition = FormStartPosition.Manual;
            child.MdiParent = this;
            child.Location = location;
            child.Show();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rectangulo = new Rectangulo();
            OpenSingleChild(rectangulo, new Point(20, 20));
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cuadrado = new Cuadrado();
            OpenSingleChild(cuadrado, new Point(20, 20));
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var triangulo = new Triangulo();
            OpenSingleChild(triangulo, new Point(20, 20));
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rombo = new Rombo();
            OpenSingleChild(rombo, new Point(20, 20));
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var romboide = new Romboide();
            OpenSingleChild(romboide, new Point(20, 20));
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var trapecio = new Trapecio();
            OpenSingleChild(trapecio, new Point(20, 20));
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var circulo = new Circulo();
            OpenSingleChild(circulo, new Point(20, 20));
        }

        private void poligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var poligono = new Poligono();
            OpenSingleChild(poligono, new Point(20, 20));
        }
    }
}