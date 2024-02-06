using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D10.enums;

namespace D10.models
{
    public class Consulta
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public StatusConsulta Status { get; set; }
        public Consulta()
        {

        }
    }
}