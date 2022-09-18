using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class UserNegocio
    {
        public bool verificarConSP(User user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.storedProcedure("storedValidarUsuario");
                datos.setParameters("@Usuario", user.Usuario);
                datos.setParameters("@Contrasenia", user.Pass);
                datos.setParameters("@Patron", "TurnosAlicia");
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
            
        }
    }
}
