using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using dominio;
namespace negocio
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;
        private List<Turno> lista = new List<Turno>();
        public EmailService()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("depilacion.alicia.22@gmail.com", "vckpzvoaoxmwrkcu");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void ArmarCorreo(List<Turno> turnos)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponderestemail@ecommerce.com");
            email.To.Add(turnos.First().paciente.Email);
            email.Subject = "Consulta de turno";
            email.IsBodyHtml = true;
            string mensaje = ArmarTurnosString(turnos);
            email.Body = $"<h1>Hola {turnos.First().paciente.NombreCompleto}.</h1>" +
                $"<h4>Sus proximos turno son:<br></h4>" + mensaje +
                $"<br/><p>Por favor, no responder este mail.</p><br/>" +
                $"<h4>Estilista Alicia Popoff.</h4>";
        }
        private string ArmarTurnosString(List<Turno> turnos)
        {
            var mensaje = new System.Text.StringBuilder();
            foreach (Turno turno in turnos)
            {
                mensaje.AppendLine($"<p>El {turno.fecha} a las {turno.hora.Horario} se realizara {turno.tratamiento.Descripcion}.</p>");
            }
            return mensaje.ToString();
        }

        public List<Turno> CargarDatos(string email)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.storedProcedure("storedDatoEmail");
                datos.setParameters("@email", email);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();
                    aux.fecha = ((DateTime)datos.Lector["Fecha"]).ToString("dd-MM-yyyy");
                    aux.hora = new Hora();
                    aux.hora.Horario = (TimeSpan)datos.Lector["Hora"];
                    aux.paciente = new Paciente();
                    aux.paciente.NombreCompleto = (string)datos.Lector["NombreCompleto"];
                    aux.paciente.Email = (string)datos.Lector["Email"];
                    aux.tratamiento = new Tratamiento();
                    aux.tratamiento.Descripcion = (string)datos.Lector["Tratamiento"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
