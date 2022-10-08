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

        TurnoNegocio negocioTurno = new TurnoNegocio();
        PacienteNegocio negocioPaciente = new PacienteNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string id = TomaId();
            if (id == "")
                Response.Redirect("ListaPacientes.aspx");
            else
            {
                try
                {
                    
                    dominio.Paciente aux = negocioPaciente.SelectItemFromId(id);
                    if (!IsPostBack)
                    {
                        lblNombreCompleto.Text += aux.NombreCompleto;
                        lblEdad.Text += aux.Edad.ToString();
                        lblEmail.Text += aux.Email;
                        lblCelular.Text += aux.Celular;
                        lblSexo.Text += aux.sexo.Sexualidad;                      
                    }
                    Session.Add("listaPacienteTurnos", negocioTurno.HistPacienteDesc(id));
                    dgvPacienteSeleccionado.DataSource = Session["listaPacienteTurnos"];
                    dgvPacienteSeleccionado.DataBind();
                }
                catch (Exception ex)
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

        protected void dgvPacienteSeleccionado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvPacienteSeleccionado.PageIndex = e.NewPageIndex;
            dgvPacienteSeleccionado.DataBind();
        }             
    }


}