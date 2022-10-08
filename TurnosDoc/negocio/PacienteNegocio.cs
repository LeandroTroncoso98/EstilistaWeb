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
                datos.storedProcedure("storedListarPacientesActivos");
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
                datos.storedProcedure("storedCrearPaciente");
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
        public Paciente SelectItemFromId(string id)
        {
            
            try
            {
                datos.storedProcedure("StoredSeleccionarCliente");
                datos.setParameters("@id", id);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    Paciente aux = new Paciente();
                    aux.id = (int)datos.Lector["Id"];
                    aux.NombreCompleto = (string)datos.Lector["NombreCompleto"];
                    aux.Edad = (int)datos.Lector["Edad"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Celular = (string)datos.Lector["Celular"];
                    aux.sexo = new Sexo();
                    aux.sexo.Id = (int)datos.Lector["IdSexo"];
                    aux.sexo.Sexualidad = (string)datos.Lector["Sexo"];
                    return aux;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarPaciente(int id)
        {
            try
            {
                datos.storedProcedure("storedDesactivarPaciente");
                datos.setParameters("@id", id);
                datos.ejecutarAccion();

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
        public void ModificarPaciente(Paciente paciente)
        {
            try
            {
                datos.storedProcedure("storedModificarPaciente");
                datos.setParameters("@id", paciente.id);
                datos.setParameters("@nombrecompleto", paciente.NombreCompleto);
                datos.setParameters("@idSexo", paciente.sexo.Id);
                datos.setParameters("@edad", paciente.Edad);
                datos.setParameters("@celular", paciente.Celular);
                datos.setParameters("@email", paciente.Email);
                datos.ejecutarAccion();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
        public List<Paciente> ListaNombresPacientes()
        {
            try
            {
                datos.storedProcedure("storedListNombrePaciente");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Paciente aux = new Paciente();
                    aux.id = (int)datos.Lector["Id"];
                    aux.NombreCompleto = (string)datos.Lector["NombreCompleto"];
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
