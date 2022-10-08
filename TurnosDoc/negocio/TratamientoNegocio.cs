using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class TratamientoNegocio
    {
        public List<Tratamiento> listar()
        {
            List<Tratamiento> lista = new List<Tratamiento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.storedProcedure("storedTratamientoListar");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Tratamiento aux = new Tratamiento();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
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
