using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D08.models
{
    public class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }
        public double Altura { get; set; }
        public Triangulo()
        {

        }
        public void CalcularArea()
        {
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Informe o valor da base do tringulo: ");
            triangulo.LadoC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor do 1 lado do triangulo: ");
            triangulo.LadoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor do 2 lado do triangulo: ");
            triangulo.LadoB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor da altura do triangulo: ");
            triangulo.Altura = Convert.ToDouble(Console.ReadLine());
            var AEB = LadoA + LadoB;
            var AEC = LadoA + LadoC;
            var BEC = LadoB + LadoC;
            if (AEB > LadoC && AEC > LadoB && BEC > LadoA)
            {
                var areaTriangulo = (triangulo.LadoC * triangulo.Altura) / 2;
                Console.WriteLine("A area do triangulo é: " + areaTriangulo);
            }
            else
            {
                Console.WriteLine("o tringulo informado não é válido.\nVerifique se os valores estão realmente corretos.");
            }
            Console.ReadKey();

        }
    }
}