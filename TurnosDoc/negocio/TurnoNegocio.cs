using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class TurnoNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        List<Turno> listaTurnos = new List<Turno>();
        
        public List<Turno> listarSP()
        {
            try
            {
                datos.storedProcedure("storedListar");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();
                    aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    else
                        aux.Descripcion = "Sin descripcion";
                    aux.fecha = ((DateTime)datos.Lector["Fecha"]).ToString("dd/MM/yyyy");
                    aux.hora = new Hora();
                    aux.hora.Id = (int)datos.Lector["IdHora"];
                    aux.hora.Horario = (TimeSpan)datos.Lector["Hora"];
                    aux.paciente = new Paciente();
                    aux.paciente.id = (int)datos.Lector["IdPaciente"];
                    aux.paciente.NombreCompleto = (string)datos.Lector["Nombre"];                 
                    aux.tratamiento = new Tratamiento();
                    aux.tratamiento.Id = (int)datos.Lector["IdTratamiento"];
                    aux.tratamiento.Descripcion = (string)datos.Lector["Tratamiento"];
                    listaTurnos.Add(aux);
                }
                return listaTurnos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Turno> HistPacienteDesc(string idString)
        {

            try
            {
                int id = int.Parse(idString);
                datos.storedProcedure("storedHistPacienteDesce");
                datos.setParameters("@id", id);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Turno turno = new Turno();
                    turno.Id = (int)datos.Lector["Id"];
                    turno.fecha = ((DateTime)datos.Lector["Fecha"]).ToString("dd-MM-yyyy");
                    turno.hora = new Hora();
                    turno.hora.Id = (int)datos.Lector["IdHora"];
                    turno.hora.Horario = (TimeSpan)datos.Lector["Hora"];
                    turno.tratamiento = new Tratamiento();
                    turno.tratamiento.Id = (int)datos.Lector["IdTratamiento"];
                    turno.tratamiento.Descripcion = (string)datos.Lector["Tratamiento"];
                    listaTurnos.Add(turno);
                }
                return listaTurnos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void crearTurno(Turno turno)
        {
            try
            {
                datos.storedProcedure("storedCrearTurno");
                datos.setParameters("@descripcion", turno.Descripcion);
                datos.setParameters("@fecha", DateTime.Parse(turno.fecha));
                datos.setParameters("@idHora", turno.hora.Id);
                datos.setParameters("@idPaciente", turno.paciente.id);
                datos.setParameters("@idTratamiento", turno.tratamiento.Id);
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
        
        
    }
}
