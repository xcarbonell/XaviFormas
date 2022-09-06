using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XaviFormas
{
    internal class Rectangulo : Poligono
    {
        private int lado1;
        private int lado2;
        public int Lado1 { get => lado1; set => lado1 = value; }
        public int Lado2 { get => lado2; set => lado2 = value; }

        public Rectangulo(int lado1, int lado2) : base(4)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public override string ToString()
        {
            return "Rectangulo de lados " + Lado1 + " y " + Lado2;
        }
        public override double CalcularArea()
        {
            return Lado1 * Lado2;
        }
        public override double CalcularPerimetro()
        {
            return 2 * Lado1 + 2 * Lado2;
        }
    }
}
