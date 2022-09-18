using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class GeneroNegocio
    {
        public List<Sexo> listar()
        {
            List<Sexo> lista = new List<Sexo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.storedProcedure("storedGenero");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Sexo aux = new Sexo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Sexualidad = (string)datos.Lector["Sexo"];
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
