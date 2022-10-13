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
        public bool vacio { get; set; }
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
            string id = dgvClientes.SelectedDataKey.Value.ToString();
            Response.Redirect("ResumenDeCliente.aspx?id=" + id);
        }

        protected void dgvClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvClientes.PageIndex = e.NewPageIndex;
            dgvClientes.DataBind();
        }       
        protected void btnfiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteNegocio negocio = new PacienteNegocio();
                dgvClientes.DataSource = negocio.listaFiltrada(txtFiltrar.Text);
                dgvClientes.DataBind();
                if (dgvClientes.Rows.Count <= 0)                
                    vacio = true;               
                else
                    vacio = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}