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
        public bool vacio { get; set; }
        private string TomaId()
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
            {

                Response.Redirect("ListaPacientes.aspx");
            }
            else
            {
                
                try
                {

                    dominio.Paciente aux = negocioPaciente.SelectItemFromId(id);
                    if (aux != null)
                    {

                        if (!IsPostBack)
                        {
                            lblNombreCompleto.Text += aux.NombreCompleto;
                            lblEdad.Text += aux.Edad.ToString();
                            lblEmail.Text += aux.Email;
                            lblCelular.Text += aux.Celular;
                            lblSexo.Text += aux.sexo.Sexualidad;
                        }
                        dgvPacienteSeleccionado.DataSource = negocioTurno.HistPacienteDesc(id);
                        dgvPacienteSeleccionado.DataBind();
                        if (dgvPacienteSeleccionado.Rows.Count <= 0)
                            vacio = true;
                        else
                            vacio = false;
                    }
                    else
                        Response.Redirect("ListaPacientes.aspx");

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

        protected void dgvPacienteSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvPacienteSeleccionado.SelectedDataKey.Value.ToString();
            Response.Redirect("ResumenDeTurno.aspx?id=" + id);
        }
    }


}