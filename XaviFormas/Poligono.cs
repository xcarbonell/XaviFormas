using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XaviFormas
{
    internal abstract class Poligono : Forma2D
    {
        private int numLados;
        public int NumLados { get => numLados; set => numLados = value; }

        public Poligono(int numLados)
        {
            this.numLados = numLados;
        }
        public override string ToString()
        {
            return "Poligono de " + numLados + " lados";
        }
    }
}
