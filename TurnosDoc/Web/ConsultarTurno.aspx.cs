using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace Web
{
    public partial class ConsultarTurno : System.Web.UI.Page
    {
        public bool MailExitoso = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEmail_Click(object sender, EventArgs e)
        {
            EmailService emailService = new EmailService();
            List<Turno> turnoConsulta = emailService.CargarDatos(txtEmail.Text);
            MailExitoso = true;
            try
            {
                if (turnoConsulta.Count != 0)
                {
                    emailService.ArmarCorreo(turnoConsulta);
                    emailService.enviarEmail();
                    lblMensaje.Text = "En breve la informacion de su proximo turno le llegara a su correo electronico.";
                }
                else
                    lblMensaje.Text = "Usted no posee turnos.";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}