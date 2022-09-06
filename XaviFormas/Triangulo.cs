using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XaviFormas
{
    internal class Triangulo : Poligono
    {
        private int baseTriangulo;
        private int altura;
        public int BaseTriangulo { get => baseTriangulo; set => baseTriangulo = value; }
        public int Altura { get => altura; set => altura = value; }

        public Triangulo(int b, int alt) : base(3)
        {
            baseTriangulo = b;
            altura = alt;
        }
        public override string ToString()
        {
            return "Triangulo de base " + baseTriangulo + " y altura " + altura;
        }
        public override double CalcularArea()
        {
            return baseTriangulo * altura / 2;
        }
        public override double CalcularPerimetro()
        {
            return 2 * baseTriangulo;
        }
    }
}
