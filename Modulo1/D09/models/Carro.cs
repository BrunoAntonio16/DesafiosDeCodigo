using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D09.models
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int VelocidadeAtual { get; set; }
        public int MarchaAtual { get; set; }
        public Carro()
        {

        }
        public void Acelerar(Carro carro)
        {
            carro.MarchaAtual++;
            carro.VelocidadeAtual += 20;
        }
        public void Frear(Carro carro)
        {
            carro.MarchaAtual--;
            carro.VelocidadeAtual -= 20;
        }
        public void ExibirVelocidade(Carro carro)
        {
            Console.WriteLine(carro.VelocidadeAtual + "KmHr");
        }
    }
}