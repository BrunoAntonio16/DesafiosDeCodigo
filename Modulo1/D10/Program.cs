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
            Console.WriteLine("1 - Adicionar Consulta.\n2 - Modificar Status de Consulta.\n3 - Exibir Consulta.\n4 - Exibir Consulta do Paciente.\n0 - Encerrar programa.");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    AdicionarConsulta(pacientes, consultas, historicoConsultas);
                    MenuUI(pacientes, consultas, historicoConsultas);
                    break;
                case "2":
                    MudarStatusConsulta(pacientes);
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
            Consulta consulta = new Consulta();
            Console.WriteLine("Informe o nome da consulta: ");
            consulta.Titulo = Console.ReadLine();
            Console.WriteLine("Informe a data da consulta(dd/mm/yyyy): ");
            var dataConsulta = Console.ReadLine();
            consulta.Data = DateTime.Parse(dataConsulta);
            Console.WriteLine("Informe o nome do paciente: ");
            var nomePaciente = Console.ReadLine();
            foreach (Paciente paciente in pacientes)
            {
                contador++;
                if (paciente.Nome.Equals(nomePaciente))
                {
                    Console.WriteLine("Paciente Existente no banco de dados!");
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
                }
                contador++;
            }
            Console.ReadKey();
        }
        static void MudarStatusConsulta(List<Paciente> pacientes)
        {
            Console.Clear();
            var opcao = 0;
            var contador = 0;
            Console.WriteLine("Informe o nome do paciente: ");
            var nomePaciente = Console.ReadLine();
            Console.WriteLine("Informe o nome da consulta: ");
            var nomeConsulta = Console.ReadLine();
            Console.WriteLine("Informe a data da consulta: ");
            var dataConsulta = Console.ReadLine();
            DateTime dataConsultaConvert = DateTime.Parse(dataConsulta);
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Nome.Equals(nomePaciente) && paciente.HistoricoConsultas[contador].Titulo.Equals(nomeConsulta) && paciente.HistoricoConsultas[contador].Data == dataConsultaConvert)
                {
                    Console.WriteLine("Informe o status da consulta.\nRealizada(1) NãoRealizada(2)");
                    if (opcao == 1)
                    {
                        paciente.HistoricoConsultas[contador].Status = enums.StatusConsulta.Realizada;
                    }
                    else if (opcao == 2)
                    {
                        paciente.HistoricoConsultas[contador].Status = enums.StatusConsulta.NaoRealizada;
                    }
                }
                else if (contador == pacientes.Count && !paciente.Nome.Equals(nomePaciente))
                {
                    Console.WriteLine("O paciente não existe na nossa base.");
                }
            }
            Console.ReadKey();
        }
        static void ExibirConsultas(List<Consulta> consultas)
        {
            Console.Clear();
            foreach (Consulta consulta in consultas)
            {
                Console.WriteLine("Titulo: " + consulta.Titulo + "\nData: " + consulta.Data + "\nStatus: " + consulta.Status);
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
                    for (int contador1 = 0; contador1 <= paciente.HistoricoConsultas.Count; contador1++)
                    {
                        Console.WriteLine("Titulo: " + paciente.HistoricoConsultas[contador1].Titulo + "\nData: " + paciente.HistoricoConsultas[contador1].Data + "\nStatus: " + paciente.HistoricoConsultas[contador1].Status);
                    }
                }
                else if (contador == pacientes.Count && !paciente.Nome.Equals(nomePaciente))
                {
                    Console.WriteLine("O paciente não existe na nossa base.");
                }
            }
            Console.ReadKey();
        }
    }
}