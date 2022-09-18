using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Hora
    {
        public int Id { get; set; }
        public TimeSpan Horario { get; set; }
        public override string ToString()
        {
            return Horario.ToString();
        }
    }
}
