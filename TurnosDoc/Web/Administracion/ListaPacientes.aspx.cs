using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace Web.Paciente
{
    public partial class Lista : System.Web.UI.Page
    {
        public List<PacienteNegocio> listaPacientes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PacienteNegocio negocio = new PacienteNegocio();
            Session.Add("listaPacientes", negocio.listarConSP());
            dgvClientes.DataSource = Session["listaPacientes"];
            dgvClientes.DataBind();
        }

        protected void dgvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dgvClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvClientes.PageIndex = e.NewPageIndex;
            dgvClientes.DataBind();
        }
    }
}