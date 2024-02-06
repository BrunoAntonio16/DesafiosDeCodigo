using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D10.models
{
    public class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Consulta> HistoricoConsultas { get; set; }
        public Paciente()
        {

        }
        public Paciente(string nome, int idade, List<Consulta> consultas)
        {
            Nome = nome;
            Idade = idade;
            HistoricoConsultas = consultas;
        }
    }
}