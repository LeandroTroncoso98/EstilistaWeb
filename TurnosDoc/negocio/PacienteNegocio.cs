using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class PacienteNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        List<Paciente> lista = new List<Paciente>();
        public List<Paciente> listarConSP()
        {
            try
            {
                datos.storedProcedure("storedListarPaciente");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Paciente aux = new Paciente();
                    aux.id = (int)datos.Lector["Id"];
                    aux.NombreCompleto = (string)datos.Lector["nombre"];
                    aux.Celular = (string)datos.Lector["Celular"];
                    aux.Edad = (int)datos.Lector["Edad"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.sexo = new Sexo();
                    aux.sexo.Id = (int)datos.Lector["IdSexo"];
                    aux.sexo.Sexualidad = (string)datos.Lector["Sexo"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void CrearPacienteSP(Paciente paciente)
        {
            try
            {
                datos.storedProcedure("storedCrearUsuario");
                datos.setParameters("@nombreCompleto", paciente.NombreCompleto);
                datos.setParameters("@idSexo", paciente.sexo.Id);
                datos.setParameters("@edad", paciente.Edad);
                datos.setParameters("@celular", paciente.Celular);
                datos.setParameters("@email", paciente.Email);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
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
