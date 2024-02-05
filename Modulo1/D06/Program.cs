namespace D06
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuUI();
        }
        static void MenuUI()
        {
            Console.WriteLine("1 - Calcular Salario Liquido.\n0 - Encerrar Programa.");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CalcularSalarioLiquido();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("A opção selecionada não corresponde as disponiveis no nosso sistema.");
                    MenuUI();
                    break;
            }
        }
        static void CalcularSalarioLiquido()
        {
            var valorTotalBonificacao = 0.0;
            var opcao = 1;
            var i = 1;
            var salarioLiquido = 0.0;
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Informe seu nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Informe seu cargo: ");
            funcionario.Cargo = Console.ReadLine();
            Console.WriteLine("Informe seu Salario: ");
            funcionario.Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("As opções abaixo são acumulativas.Cada valor digitado vai ser somado ao anterior.\nCaso você já tenha adicionado todos os bonus e deseja sair do loop digite(1) se não digite(0).");
            do
            {
                Console.WriteLine($"Informe o valor da sua {i}° Bonificação: ");
                var bonificacao = Convert.ToDouble(Console.ReadLine());
                valorTotalBonificacao += bonificacao;
                Console.WriteLine("Você deseja sair do loop? (1)Sair (0)Não");
                opcao = int.Parse(Console.ReadLine());
                i++;
            } while (i != 0 && opcao != 1);
            salarioLiquido = funcionario.Salario - valorTotalBonificacao;
            Console.WriteLine("O valor do seu salário liquido é: " + salarioLiquido);
            Console.ReadKey();
        }
    }
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
    }
}
