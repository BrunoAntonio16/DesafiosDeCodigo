using D10.models;

namespace D10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Consulta> historicoConsultas = new List<Consulta>();
            List<Consulta> consultas = new List<Consulta>();
            List<Paciente> pacientes = new List<Paciente>();
            Paciente paciente = new Paciente("Bruno Antonio", 19, historicoConsultas);
            Paciente paciente1 = new Paciente("Robson Maurino", 35, historicoConsultas);
            Paciente paciente2 = new Paciente("Gustavo Lira", 70, historicoConsultas);
            Paciente paciente3 = new Paciente("ludcreusa", 90, historicoConsultas);
            Paciente paciente4 = new Paciente("Clara Escura", 22, historicoConsultas);
            pacientes.Add(paciente);
            pacientes.Add(paciente1);
            pacientes.Add(paciente2);
            pacientes.Add(paciente3);
            pacientes.Add(paciente4);
            MenuUI(pacientes, consultas, historicoConsultas);
            // paciente.HistoricoConsultas.Append(consultas[1]);
        }
        static void MenuUI(List<Paciente> pacientes, List<Consulta> consultas, List<Consulta> historicoConsultas)
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar Consulta.\n2 - Modificar Status de Consulta.\n3 - Exibir Consultas.\n4 - Exibir Consultas do Paciente.\n5 - Exibir Pacientes.\n0 - Encerrar programa.");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    AdicionarConsulta(pacientes, consultas, historicoConsultas);
                    MenuUI(pacientes, consultas, historicoConsultas);
                    break;
                case "2":
                    MudarStatusConsulta(consultas, pacientes);
                    MenuUI(pacientes, consultas, historicoConsultas);
                    break;
                case "3":
                    ExibirConsultas(consultas);
                    MenuUI(pacientes, consultas, historicoConsultas);
                    break;
                case "4":
                    ExibirConsultasPaciente(pacientes, consultas);
                    MenuUI(pacientes, consultas, historicoConsultas);
                    break;
                case "5":
                    ExibirPacientes(pacientes);
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("A opção selecionada não existe!!!");
                    break;
            }
        }
        static void AdicionarConsulta(List<Paciente> pacientes, List<Consulta> consultas, List<Consulta> historicoConsultas)
        {
            Console.Clear();
            var contador = -1;
            Consulta consulta = new Consulta(enums.StatusConsulta.SemStatus);
            Console.WriteLine("Informe o nome da consulta: ");
            consulta.Titulo = Console.ReadLine();
            Console.WriteLine("Informe a data da consulta(dd/mm/yyyy): ");
            var dataConsulta = Console.ReadLine();
            consulta.Data = DateTime.Parse(dataConsulta);
            Console.WriteLine("Informe o nome do paciente: ");
            var nomePaciente = Console.ReadLine();
            consulta.nomePaciente = nomePaciente;
            foreach (Paciente paciente in pacientes)
            {
                contador++;
                if (paciente.Nome.Equals(nomePaciente))
                {
                    Console.WriteLine("Consulta Cadastrada Com Sucesso!!!");
                    consultas.Add(consulta);
                    // for(int contador1 = 0; contador1 <= consultas.Count; contador1++)
                    // {
                    //     if()
                    //     {

                    //     }
                    // }
                    paciente.HistoricoConsultas.Add(consulta);
                }
                else if (contador == pacientes.Count && !paciente.Nome.Equals(nomePaciente))
                {
                    Console.WriteLine("O paciente não existe na nossa base.\nRealize o cadastro do mesmo.");
                    Paciente paciente1 = new Paciente();
                    Console.WriteLine("Informe o nome do paciente: ");
                    paciente1.Nome = Console.ReadLine();
                    Console.WriteLine("Informe a idade do paciente: ");
                    paciente1.Idade = int.Parse(Console.ReadLine());
                    pacientes.Add(paciente1);
                    consultas.Add(consulta);
                    paciente1.HistoricoConsultas.Add(consulta);
                    Console.WriteLine("Consulta Cadastrada Com Sucesso!!!");
                }
                contador++;
            }
            Console.ReadKey();
        }
        static void MudarStatusConsulta(List<Consulta> consultas, List<Paciente> pacientes)
        {
            Console.Clear();
            var contador = 0;
            Console.WriteLine("Informe o nome do paciente: ");
            var nomePaciente = Console.ReadLine();
            Console.WriteLine("Informe o nome da consulta: ");
            var nomeConsulta = Console.ReadLine();
            Console.WriteLine("Informe a data da consulta: ");
            var dataConsulta = Console.ReadLine();
            DateTime dataConsultaConvert = DateTime.Parse(dataConsulta);
            foreach (Consulta consulta in consultas)
            {
                if (consulta.Titulo.Equals(nomeConsulta) && consulta.nomePaciente.Equals(nomePaciente) && consulta.Data == dataConsultaConvert)
                {
                    Console.WriteLine("Titulo: " + consulta.Titulo + "\nNome do Paciente: " + consulta.nomePaciente + "\nData: " + consulta.Data + "\nStatus: " + consulta.Status);
                    Console.WriteLine("Informe o status da consulta.\nRealizada(1) NãoRealizada(2)");
                    var opcao = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                    {
                        consulta.Status = enums.StatusConsulta.Realizada;
                    }
                    else if (opcao == 2)
                    {
                        consulta.Status = enums.StatusConsulta.NaoRealizada;
                    }
                    // foreach (Paciente paciente in pacientes)
                    // {
                    //     if (nomePaciente.Equals(nomePaciente))
                    //     {
                    //         if (paciente.HistoricoConsultas[contador].Titulo.Equals(nomeConsulta) && paciente.HistoricoConsultas[contador].Data == dataConsultaConvert)
                    //         {
                    //             if (opcao == 1)
                    //             {
                    //                 paciente.HistoricoConsultas[contador].Status = enums.StatusConsulta.Realizada;
                    //             }
                    //             else if (opcao == 2)
                    //             {
                    //                 paciente.HistoricoConsultas[contador].Status = enums.StatusConsulta.NaoRealizada;
                    //             }
                    //         }
                    //         contador++;
                    //     }
                    // }
                }
                else if (contador == consultas.Count && !consulta.nomePaciente.Equals(nomePaciente))
                {
                    Console.WriteLine("O paciente não existe na nossa base!.");
                }
                else if (contador == consultas.Count && !consulta.Titulo.Equals(nomeConsulta) || consulta.Data != dataConsultaConvert)
                {
                    Console.WriteLine("Consulta não encontrada!.");
                }
                contador++;
            }
            Console.ReadKey();
        }
        static void ExibirConsultas(List<Consulta> consultas)
        {
            var contador = 0;
            Console.Clear();
            foreach (Consulta consulta in consultas)
            {
                Console.WriteLine(contador + "°" + "\n Titulo: " + consulta.Titulo + "\n Data: " + consulta.Data + "\n Status: " + consulta.Status + "\n Nome do Paciente: " + consulta.nomePaciente);
                contador++;
            }
            Console.ReadKey();
        }
        static void ExibirConsultasPaciente(List<Paciente> pacientes, List<Consulta> consultas)
        {
            Console.Clear();
            var contador = 0;
            Console.WriteLine("Informe o nome do paciente: ");
            var nomePaciente = Console.ReadLine();
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Nome.Equals(nomePaciente))
                {
                    for (int contador1 = 0; contador1 < paciente.HistoricoConsultas.Count; contador1++)
                    {
                        Console.WriteLine(contador1 + "°" + "\n Titulo: " + paciente.HistoricoConsultas[contador1].Titulo + "\n Data: " + paciente.HistoricoConsultas[contador1].Data + "\n Status: " + paciente.HistoricoConsultas[contador1].Status);
                    }
                }
                else if (contador == pacientes.Count && !paciente.Nome.Equals(nomePaciente))
                {
                    Console.WriteLine("O paciente não existe na nossa base.");
                }
            }
            Console.ReadKey();
        }
        static void ExibirPacientes(List<Paciente> pacientes)
        {
            Console.Clear();
            foreach (Paciente paciente in pacientes)
            {
                Console.WriteLine("Nome: " + paciente.Nome + "\nIdade: " + paciente.Idade);
            }
            Console.ReadKey();
        }
    }
}