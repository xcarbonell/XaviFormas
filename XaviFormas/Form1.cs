using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XaviFormas
{
    public partial class Form1 : Form
    {

        List<Forma2D> formas = new List<Forma2D>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radio = rand.Next(20);
            Circulo c = new Circulo(radio);
            formas.Add(c);
            listFormas.Items.Add(c.ToString());
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int b = rand.Next(20);
            int h = rand.Next(20);
            Triangulo t = new Triangulo(b, h);
            formas.Add(t);
            listFormas.Items.Add(t.ToString());
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int lado1 = rand.Next(20);
            int lado2 = rand.Next(20);
            Rectangulo r = new Rectangulo(lado1, lado2);
            formas.Add(r);
            listFormas.Items.Add(r.ToString());
        }

        private void btnVerDiagrama_Click(object sender, EventArgs e)
        {
            listFormas.Items.Clear();
            foreach (Forma2D forma in formas)
            {
                listFormas.Items.Add(forma.ToString());
            }
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            listFormas.Items.Clear();
            double sumArea = 0.0;
            foreach (Forma2D forma in formas)
            {
                sumArea += forma.CalcularArea();
            }
            listFormas.Items.Add(sumArea);
        }

        private void btnEliminarForma_Click(object sender, EventArgs e)
        {
            formas.RemoveAt(listFormas.SelectedIndex);
            btnVerDiagrama_Click(sender, e);
        }

        private void btnFormaAleatoria_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int lado1 = rand.Next(20);
            int lado2 = rand.Next(20);

            Random rand2 = new Random();
            switch (rand2.Next(3))
            {
                case 0:
                    Rectangulo r = new Rectangulo(lado1, lado2);
                    formas.Add(r);
                    listFormas.Items.Add(r.ToString());
                    break;
                case 1:
                    Triangulo t = new Triangulo(lado1, lado2);
                    formas.Add(t);
                    listFormas.Items.Add(t.ToString());
                    break;
                case 2:
                    Circulo c = new Circulo(lado1);
                    formas.Add(c);
                    listFormas.Items.Add(c.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
