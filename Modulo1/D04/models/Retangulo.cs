using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D04.models
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public void CalcularArea(float altura, float largura)
        {
            var areaRetangulo = 0.0;
            areaRetangulo = largura * altura;
            Console.WriteLine("A area do retângulo é: " + areaRetangulo);
        }
        public void CalcularPerimetro(float altura, float largura)
        {
            var perimetroRetangulo = 0.0;
            perimetroRetangulo = 2 * (altura + largura);
            Console.WriteLine("O perimetro do retângulo é: " + perimetroRetangulo);
        }
    }

}