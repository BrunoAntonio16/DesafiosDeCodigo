using D09.models;

namespace D09
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "Chevrolet";
            carro.Modelo = "Onix";
            carro.ExibirVelocidade(carro);
            carro.Acelerar(carro);
            carro.ExibirVelocidade(carro);
            carro.Acelerar(carro);
            carro.ExibirVelocidade(carro);
            carro.Acelerar(carro);
            carro.ExibirVelocidade(carro);
            carro.Frear(carro);
            carro.ExibirVelocidade(carro);
        }
    }
}