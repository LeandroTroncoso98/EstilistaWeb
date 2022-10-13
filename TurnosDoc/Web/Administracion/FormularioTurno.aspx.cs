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
    public partial class FormularioTurno : System.Web.UI.Page
    {
        private string TomaId()
        {
            string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
            return id;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    PacienteNegocio pacienteNegocio = new PacienteNegocio();
                    List<dominio.Paciente> pacientesLista = pacienteNegocio.ListaNombresPacientes();
                    HoraNegocio horaNegocio = new HoraNegocio();
                    List<Hora> horas = horaNegocio.ListarHora();
                    TratamientoNegocio tratamientoNegocio = new TratamientoNegocio();
                    List<Tratamiento> tratamientos = tratamientoNegocio.listar();
                    ddlNombre.DataSource = pacientesLista;
                    ddlNombre.DataValueField = "Id";
                    ddlNombre.DataTextField = "NombreCompleto";
                    ddlNombre.DataBind();
                    ddlHora.DataSource = horas;
                    ddlHora.DataValueField = "Id";
                    ddlHora.DataTextField = "Horario";
                    ddlHora.DataBind();
                    ddlTratamiento.DataSource = tratamientos;
                    ddlTratamiento.DataValueField = "Id";
                    ddlTratamiento.DataTextField = "Descripcion";
                    ddlTratamiento.DataBind();
                    string id = TomaId();
                    if (id != "" && !IsPostBack)
                    {
                        TurnoNegocio turnoNegocio = new TurnoNegocio();
                        Turno aux = turnoNegocio.SelectItemFromId(id);
                        if (aux != null)
                        {
                            ddlNombre.SelectedValue = aux.paciente.id.ToString();
                            ddlHora.SelectedValue = aux.hora.Id.ToString();
                            ddlTratamiento.SelectedValue = aux.tratamiento.Id.ToString();
                            txtFecha.Text = String.Format("{0:yyyy-MM-dd}", DateTime.Parse(aux.fecha));
                            txtDescripcion.Text = aux.Descripcion;
                            btnCrear.Text = "Modificar";
                        }
                        else
                            Response.Redirect("Horarios.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Turno nuevo = new Turno();
                TurnoNegocio negocio = new TurnoNegocio();
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.fecha = txtFecha.Text;
                nuevo.hora = new Hora();
                nuevo.hora.Id = int.Parse(ddlHora.SelectedValue);
                nuevo.paciente = new dominio.Paciente();
                nuevo.paciente.id = int.Parse(ddlNombre.SelectedValue);
                nuevo.tratamiento = new Tratamiento();
                nuevo.tratamiento.Id = int.Parse(ddlTratamiento.SelectedValue);
                if (Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(TomaId());
                    negocio.EditarTurno(nuevo);
                }
                else
                    negocio.crearTurno(nuevo);
                Response.Redirect("Horarios.aspx", false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        protected void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioPaciente.aspx", false);
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            if (TomaId() == "" || TomaId() == null)
                Response.Redirect("Horarios.aspx");
            else
                Response.Redirect("ResumenDeTurno.aspx?id=" + TomaId());
        }
    }
}