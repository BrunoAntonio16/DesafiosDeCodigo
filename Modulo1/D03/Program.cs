using System.ComponentModel;
using D03.models;

namespace D03
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria1 = new ContaBancaria();
            contaBancaria1.TitularConta = "Bruno Antonio";
            contaBancaria1.NumeroConta = 1983454;
            contaBancaria1.SaldoConta = (float)500.00;
            ContaBancaria contaBancaria2 = new ContaBancaria();
            contaBancaria2.TitularConta = "Breno Alexandrino";
            contaBancaria2.NumeroConta = 1029435;
            contaBancaria2.SaldoConta = (float)2000.00;
            ContaBancaria contaBancaria3 = new ContaBancaria();
            contaBancaria2.TitularConta = "Gleybson Carneiro";
            contaBancaria2.NumeroConta = 0439567;
            contaBancaria2.SaldoConta = (float)1000.00;
            List<ContaBancaria> contaBancarias = new List<ContaBancaria>();
            contaBancarias.Add(contaBancaria1);
            contaBancarias.Add(contaBancaria2);
            contaBancarias.Add(contaBancaria3);
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine(" -------------------- ");
                Console.WriteLine("1 - Realizar Deposito.\n2 - Realizar Saque.\n3 - Consultar Conta\n0 - Sair do Programa.");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        RealizarDeposito(contaBancarias);
                        break;
                    case "2":
                        RealizarSaque(contaBancarias);
                        break;
                    case "3":
                        ConsultarInformacoesConta(contaBancarias);
                        break;
                    case "0":
                        Console.WriteLine("Encerrando programa...");
                        continuar = false;
                        break;
                    default:
                        break;
                }
            } while (continuar != false);
        }
        static void MenuUI()
        {
            // string option = "";
            // Console.WriteLine(" -------------------- ");
            // Console.WriteLine(" 1 - Realizar Deposito.\n2 - Realizar Saque.\n0 - Sair do Programa.");
            // switch (option)
            // {
            //     case "1":
            //         RealizarDeposito();
            //         break;
            //     case "2":
            //         break;
            //     case "0":
            //         Console.WriteLine("Encerrando programa.");
            //         break;
            //     default:
            //         break;
            // }
        }
        static void RealizarDeposito(List<ContaBancaria> contaBancarias)
        {
            Console.Clear();
            Console.WriteLine("--------- Deposito --------");
            Console.WriteLine("Informe o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            foreach (ContaBancaria contaBancaria in contaBancarias)
            {
                if (contaBancaria.NumeroConta == numeroConta)
                {
                    Console.WriteLine("Informe a quantidade de dinheiro que deseja depositar: ");
                    int quantidadeDeposito = int.Parse(Console.ReadLine());
                    contaBancaria.SaldoConta += quantidadeDeposito;
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine("Deposito Realizado...");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("O numero da conta não corresponde as contas presentes no nosso sistema.");
                Console.ReadKey();
            }
        }
        static void RealizarSaque(List<ContaBancaria> contaBancarias)
        {
            Console.Clear();
            Console.WriteLine("---------- Saque ---------");
            Console.WriteLine("Informe o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            foreach (ContaBancaria contaBancaria in contaBancarias)
            {
                if (contaBancaria.NumeroConta == numeroConta)
                {
                    Console.WriteLine("Informe a quantidade de dinheiro que deseja sacar: ");
                    int quantidadeSaque = int.Parse(Console.ReadLine());
                    if (quantidadeSaque > contaBancaria.SaldoConta)
                    {
                        Console.WriteLine("O valor informado ultrapassa o valor presente em sua conta.");
                        // MenuUI();
                        Console.ReadKey();
                        break;
                    }
                    contaBancaria.SaldoConta -= quantidadeSaque;
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine("Saque Realizado...");
                    // MenuUI();
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("O numero da conta não corresponde as contas presentes no nosso sistema.");
                Console.ReadKey();
            }
        }
        static void ConsultarInformacoesConta(List<ContaBancaria> contaBancarias)
        {
            Console.Clear();
            Console.WriteLine("---------- Consultar Conta ---------");
            Console.WriteLine("Informe o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            foreach (ContaBancaria contaBancaria in contaBancarias)
            {
                if (contaBancaria.NumeroConta == numeroConta)
                {
                    Console.WriteLine("Titular da Conta: " + contaBancaria.TitularConta + "\nNumero da conta: " + contaBancaria.NumeroConta + "\nSaldo: " + contaBancaria.SaldoConta);
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("O numero da conta não corresponde as contas presentes no nosso sistema.");
                Console.ReadKey();
            }
        }
    }
}