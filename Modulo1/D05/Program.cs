using D05.models;

namespace D05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno aluno1 = new Aluno("Barry Clark", "198580");
            Aluno aluno2 = new Aluno("Oliver Queen", "198990");
            Aluno aluno3 = new Aluno("Castiel Stark", "197540");
            alunos.Add(aluno1);
            alunos.Add(aluno2);
            alunos.Add(aluno3);
            MenuUI(alunos);
        }
        static void MenuUI(List<Aluno> alunos)
        {
            Console.Clear();
            Aluno aluno = new Aluno();
            Console.WriteLine("1 - Calcular media do Aluno.\n2 - Verificar situação do aluno.\n0 - Encerrar programa.");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    CalcularMediaAluno(alunos);
                    MenuUI(alunos);
                    break;
                case "2":
                    VerificarSituacaoAluno(alunos);
                    MenuUI(alunos);
                    break;
                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("A opção selecionada não corresponde as existentes");
                    MenuUI(alunos);
                    break;
            }
        }
        static void CalcularMediaAluno(List<Aluno> alunos)
        {
            Console.Clear();
            var mediaAluno = 0.0;
            Console.WriteLine("Informe a matricula do aluno: ");
            string matriculaAluno = Console.ReadLine();
            var contador = 0;
            foreach (Aluno aluno in alunos)
            {
                if (matriculaAluno.Equals(aluno.Matricula))
                {
                    Console.WriteLine("Informe a primeira nota do aluno: ");
                    aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe a segunda nota do aluno: ");
                    aluno.Nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe a terceira nota do aluno: ");
                    aluno.Nota3 = Convert.ToDouble(Console.ReadLine());
                    mediaAluno = (aluno.Nota1 + aluno.Nota2 + aluno.Nota3) / 3;
                    Console.WriteLine("A média do aluno " + aluno.Matricula + " é: " + mediaAluno);
                    if (mediaAluno < 7.0)
                    {
                        aluno.Situacao = false;
                    }
                    else
                    {
                        aluno.Situacao = true;
                    }
                    Console.ReadKey();
                    break;
                }
                else if (contador == 5 && !matriculaAluno.Equals(aluno.Matricula))
                {
                    Console.WriteLine("Aluno não encontrado em nosso sistema!!!");
                    Console.ReadKey();
                    // break;
                }
                contador++;
            }
        }
        static void VerificarSituacaoAluno(List<Aluno> alunos)
        {
            Console.Clear();
            Console.WriteLine("Informe a matricula do aluno: ");
            string matriculaAluno = Console.ReadLine();
            var contador = 0;
            foreach (Aluno aluno in alunos)
            {
                if (matriculaAluno.Equals(aluno.Matricula))
                {
                    Console.WriteLine("Matricula: " + aluno.Matricula + "\nNome: " + aluno.Nome);
                    if (aluno.Situacao == false)
                    {
                        Console.WriteLine("Situação: Reprovado.");
                    }
                    else
                    {
                        Console.WriteLine("Situação: Aprovado.");
                    }
                    Console.ReadKey();
                    break;
                }
                else if (contador == 5 && !matriculaAluno.Equals(aluno.Matricula))
                {
                    Console.WriteLine("Aluno não encontrado em nosso sistema!!!");
                    Console.ReadKey();
                    // break;
                }
            }
        }
    }
}