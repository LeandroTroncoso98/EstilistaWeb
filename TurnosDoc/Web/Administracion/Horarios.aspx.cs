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
    public partial class Horarios : System.Web.UI.Page
    {
        public List<Turno> listaTurnos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            Session.Add("listaTurnos", negocio.listarSP());
            dgvHorario.DataSource = Session["listaTurnos"];
            dgvHorario.DataBind();
        }

        protected void dgvHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvHorario.SelectedDataKey.Value.ToString();
            Response.Redirect(""+ id);
        }

        protected void dgvHorario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvHorario.PageIndex = e.NewPageIndex;
            dgvHorario.DataBind();
        }
    }
}