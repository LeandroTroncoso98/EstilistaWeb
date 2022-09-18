using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Paciente
    {
        public int id { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public Sexo sexo { get; set; }
        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
