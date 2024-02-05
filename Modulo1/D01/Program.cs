using System.ComponentModel;
using D01.models;

namespace D01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Bruno";
            p1.DataDeNascimento = "02/10/2004";
            p1.Altura = (float)1.76;
            ImprimirDadosPessoa(p1);
            CalcularIdadeAtualPessoa();
        }
        static void ImprimirDadosPessoa(Pessoa pessoa)
        {
            Console.WriteLine("Nome: " + pessoa.Nome + "\nData de Nascimento: " + pessoa.DataDeNascimento + "\nAltura: " + pessoa.Altura);
        }
        static void CalcularIdadeAtualPessoa()
        {
            int idadePessoa;
            Console.WriteLine("Informe o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("informe a seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            idadePessoa = anoAtual - anoNascimento;
            Console.WriteLine(idadePessoa);
        }
    }
    // public class Pessoa
    // {
    //     public string Nome { get; set; }
    //     public string DataDeNascimento { get; set; }
    //     public float Altura { get; set; }

    // }
}