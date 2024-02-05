using D02.models;

namespace D02
{
    class Program
    {
        static void Main(string[] args)
        {
            var pi = 3.14;
            Circulo c1 = new Circulo();
            c1.Raio = 2;
            c1.CalcularArea(c1.Raio, pi);
            c1.CalcularPerimetro(c1.Raio, pi);
        }
        // static void CalcularArea(double raio, double pi)
        // {
        //     double areaCirculo = pi * raio;
        //     Console.WriteLine("A área do cirulo é: " + areaCirculo);
        // }
        // static void CalcularPerimetro(double raio, double pi)
        // {
        //     double perimetroCirculo = 2 * pi * raio;
        //     Console.WriteLine("O Perimetro do cirulo é: " + perimetroCirculo);
        // }
    }
    // public class Circulo
    // {
    //     public float Raio { get; set; }
    //     public void CalcularArea(double raio, double pi)
    //     {
    //         double areaCirculo = pi * raio;
    //         Console.WriteLine("A área do cirulo é: " + areaCirculo);
    //     }
    //     public void CalcularPerimetro(double raio, double pi)
    //     {
    //         double perimetroCirculo = 2 * pi * raio;
    //         Console.WriteLine("O Perimetro do cirulo é: " + perimetroCirculo);
    //     }
    // }
}