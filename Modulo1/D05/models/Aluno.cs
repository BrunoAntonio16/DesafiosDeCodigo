using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D05.models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public bool Situacao { get; set; }
        public Aluno()
        {

        }
        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
        // static void CalcularMediaAluno(Aluno aluno, double nota1, double nota2, double nota3)
        // {
        //     var mediaAluno = 0.0;
        //     mediaAluno = (nota1 + nota2 + nota3) / 3;
        //     Console.WriteLine("A média do aluno " + aluno.Matricula + " é: " + mediaAluno);
        //     if (mediaAluno < 7.0)
        //     {
        //         aluno.Situacao = false;
        //     }
        //     else
        //     {
        //         aluno.Situacao = true;
        //     }
        // }
        // public void VerificarSituacaoAluno(Aluno aluno)
        // {
        //     Console.WriteLine("Matricula: " + aluno.Matricula + "\nNome: " + aluno.Nome + "\nSituação: " + aluno.Situacao);
        // }
    }
}