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
                    aux.fecha = ((DateTime)datos.Lector["Fecha"]).ToString("MM/dd/yyyy");
                    aux.hora = new Hora();
                    aux.hora.Id = (int)datos.Lector["IdHora"];
                    aux.hora.Horario = (TimeSpan)datos.Lector["Hora"];
                    aux.paciente = new Paciente();
                    aux.paciente.id = (int)datos.Lector["IdPaciente"];
                    aux.paciente.NombreCompleto = (string)datos.Lector["Nombre"];
                    listaTurnos.Add(aux);
                }
                return listaTurnos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
