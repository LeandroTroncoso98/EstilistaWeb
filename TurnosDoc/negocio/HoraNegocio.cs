using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class HoraNegocio
    {
        List<Hora> lista = new List<Hora>();
        public List<Hora> ListarHora()
        {

            try
            {
                
                AccesoDatos datos = new AccesoDatos();
                datos.storedProcedure("storedListHora");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Hora aux = new Hora();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Horario = (TimeSpan)datos.Lector["Hora"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
