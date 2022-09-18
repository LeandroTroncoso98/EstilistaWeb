using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Turno
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string  fecha { get; set; }
        public Hora hora { get; set; }
        public Paciente paciente { get; set; }
        
    }
}
