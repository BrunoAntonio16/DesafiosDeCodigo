using D04.models;
using System.Runtime.InteropServices;

namespace D04
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Calcule a Área e o Perimetrô de um Retângulo");
            Console.WriteLine("Informe a Altura do seu retângulo: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a Largura(base) do seu retângulo: ");
            retangulo.Largura = Convert.ToDouble(Console.ReadLine());
            MenuUI(retangulo);
        }
        static void MenuUI(Retangulo retangulo)
        {
            Console.Clear();
            Console.WriteLine("1 - Calcule a Area do seu retângulo.\n2 - Calcule o Perimetro do seu Retângulo\n0 - Encerrar o programa.");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    retangulo.CalcularArea((float)retangulo.Altura, (float)retangulo.Largura);
                    Console.ReadKey();
                    MenuUI(retangulo);
                    break;
                case "2":
                    Console.Clear();
                    retangulo.CalcularPerimetro((float)retangulo.Altura, (float)retangulo.Largura);
                    Console.ReadKey();
                    MenuUI(retangulo);
                    break;
                case "0":
                    Console.Clear();
                    Console.WriteLine("Encerrando programa...");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("A opção informa não corresponde as opções existentes");
                    Console.ReadKey();
                    MenuUI(retangulo);
                    break;
            }
        }
    }
}