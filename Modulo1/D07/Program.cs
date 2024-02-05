using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D07.models;
namespace D07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Produto produto1 = new Produto("Teclado Yakusa", 200.00, 100);
            Produto produto2 = new Produto("Monitor Stream", 1200.00, 50);
            Produto produto3 = new Produto("Mouse GranMestre", 2000.00, 0);
            produtos.Add(produto1);
            produtos.Add(produto2);
            produtos.Add(produto3);
            // Console.WriteLine(produtos.Capacity);
            MenuUI(produtos);
        }
        static void MenuUI(List<Produto> produtos)
        {
            Console.Clear();
            Produto produto = new Produto();
            Console.WriteLine("Bem vindo a GeekStore");
            Console.WriteLine("1 - Listar Produtos.\n2 - Calcular valor total do estoque.\n3 - Verificar se o produto está disponivel.\n0 - Encerrar Programa.");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    produto.ListarProdutos(produtos);
                    Console.ReadKey();
                    MenuUI(produtos);
                    break;
                case "2":
                    Console.Clear();
                    produto.CalcularValorTotalEmEstoque(produtos);
                    Console.ReadKey();
                    MenuUI(produtos);
                    break;
                case "3":
                    Console.Clear();
                    produto.VerificarSeProdutoDisponivel(produtos);
                    Console.ReadKey();
                    MenuUI(produtos);
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("A opção escolhida não existe!!!");
                    Console.ReadKey();
                    MenuUI(produtos);
                    break;
            }
        }
    }
}