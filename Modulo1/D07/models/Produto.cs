using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D07.models
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public Produto()
        {

        }
        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
        public void CalcularValorTotalEmEstoque(List<Produto> produtos)
        {
            var contador1 = 0;
            var valorTotalEstoque = 0.0;
            Console.WriteLine("Informe o nome do produto: ");
            var nomeProduto = Console.ReadLine();
            foreach (Produto produto in produtos)
            {
                contador1++;
                if (nomeProduto.Equals(produto.Nome))
                {
                    if (produto.Estoque == 0)
                    {
                        valorTotalEstoque = 0;
                        Console.WriteLine("Nome: " + produto.Nome + "\nPreco unitario: " + produto.Preco + "\nEstoque: " + produto.Estoque + "\nPreco total em relação ao estoque: " + valorTotalEstoque);
                    }
                    else
                    {
                        for (int contador = 0; contador <= produto.Estoque; contador++)
                        {
                            valorTotalEstoque += produto.Preco;
                        }
                        Console.WriteLine("Nome: " + produto.Nome + "\nPreco unitario: " + produto.Preco + "\nEstoque: " + produto.Estoque + "\nPreco total em relação ao estoque: " + valorTotalEstoque);
                    }
                }
                else if (contador1 == produtos.Count && !nomeProduto.Equals(produto.Nome))
                {
                    Console.WriteLine("Esse produto não existe em nosso sistema.");
                }
            }
        }
        public void VerificarSeProdutoDisponivel(List<Produto> produtos)
        {
            var contador1 = 0;
            Console.WriteLine("Informe o nome do produto: ");
            var nomeProduto = Console.ReadLine();
            foreach (Produto produto in produtos)
            {
                contador1++;
                if (nomeProduto.Equals(produto.Nome))
                {
                    if (produto.Estoque == 0)
                    {
                        Console.WriteLine("Produto em falta!!!" + "\nNome: " + produto.Nome + "\nEstoque: " + produto.Estoque);
                    }
                    else
                    {
                        Console.WriteLine("Produto Disponivel!!" + "\nNome: " + produto.Nome + "\nEstoque: " + produto.Estoque);
                    }
                }
                else if (contador1 == produtos.Count && !nomeProduto.Equals(produto.Nome))
                {
                    Console.WriteLine("Esse produto não existe em nosso sistema.");
                }
                // contador1++;
            }
        }
        public void ListarProdutos(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine("Nome: " + produto.Nome + "\nPreco unitario: " + produto.Preco + "\nEstoque: " + produto.Estoque);
            }
        }
    }
}