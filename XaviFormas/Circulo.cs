using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XaviFormas
{
    internal class Circulo : Forma2D
    {
        private double radio;
        public double Radio { get => radio; set => radio = value; }

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string ToString()
        {
            return "Circulo de radio " + radio;
        }
        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
