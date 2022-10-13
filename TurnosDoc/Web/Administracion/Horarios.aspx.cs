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
        public bool vacio { get; set; }
        public List<Turno> listaTurnos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            Session.Add("listaTurnos", negocio.listarSP());
            dgvHorario.DataSource = Session["listaTurnos"];
            dgvHorario.DataBind();         
            if (!IsPostBack)
            {
                TratamientoNegocio tratamientoNegocio = new TratamientoNegocio();
                List<Tratamiento> listTratamiento = tratamientoNegocio.listar();
                ddlTratamiento.Items.Add("Todos");
                foreach (Tratamiento tratamiento in listTratamiento)
                {
                    ddlTratamiento.Items.Add(tratamiento.ToString());
                }
            }
        }

        protected void dgvHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvHorario.SelectedDataKey.Value.ToString();
            Response.Redirect("ResumenDeTurno.aspx?id=" + id);
        }

        protected void dgvHorario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvHorario.PageIndex = e.NewPageIndex;
            dgvHorario.DataBind();
        }

        protected void ddlTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcion = ddlTratamiento.SelectedIndex;
            TurnoNegocio turnoNegocio = new TurnoNegocio();
            try
            {
                switch (opcion)
                {
                    case 0:
                        dgvHorario.DataSource = turnoNegocio.TurnosFiltradosXTratamiento("");
                        dgvHorario.DataBind();
                        break;
                    case 1:
                        dgvHorario.DataSource = turnoNegocio.TurnosFiltradosXTratamiento("Depilacion laser");
                        dgvHorario.DataBind();
                        break;
                    case 2:
                        dgvHorario.DataSource = turnoNegocio.TurnosFiltradosXTratamiento("Extension pelo por pelo");
                        dgvHorario.DataBind();
                        break;
                    case 3:
                        dgvHorario.DataSource = turnoNegocio.TurnosFiltradosXTratamiento("Depilacion española");
                        dgvHorario.DataBind();
                        break;
                    case 4:
                        dgvHorario.DataSource = turnoNegocio.TurnosFiltradosXTratamiento("Perfilado de cejas");
                        dgvHorario.DataBind();
                        break;
                    
                }
                if (dgvHorario.Rows.Count <= 0)
                {
                    vacio = true;
                }
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