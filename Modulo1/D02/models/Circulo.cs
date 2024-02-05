using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D02.models
{
    public class Circulo
    {
        public float Raio { get; set; }
        public void CalcularArea(double raio, double pi)
        {
            double areaCirculo = pi * raio;
            Console.WriteLine("A área do cirulo é: " + areaCirculo);
        }
        public void CalcularPerimetro(double raio, double pi)
        {
            double perimetroCirculo = 2 * pi * raio;
            Console.WriteLine("O Perimetro do cirulo é: " + perimetroCirculo);
        }
    }
}