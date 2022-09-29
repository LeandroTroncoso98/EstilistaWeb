using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace Web.Administracion
{
    public partial class ResumenDeCliente : System.Web.UI.Page
    {
        public string TomaId()
        {
            string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
            return id;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = TomaId();
            if (id == "")
                Response.Redirect("ListaPacientes.aspx");
            else
            {
                try
                {
                    PacienteNegocio negocio = new PacienteNegocio();
                    dominio.Paciente aux = negocio.SelectItemFromId(id);
                    lblNombreCompleto.Text += aux.NombreCompleto;
                    lblEdad.Text += aux.Edad.ToString();
                    lblEmail.Text += aux.Email;
                    lblCelular.Text += aux.Celular;
                    lblSexo.Text += aux.sexo.Sexualidad;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        

        protected void btnEditarCliente_Click(object sender, EventArgs e)
        {
            string id = TomaId();
            Response.Redirect("FormularioPaciente.aspx?id=" + id);
        }
    }
}