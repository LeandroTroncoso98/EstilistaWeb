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
                }
            }
            catch(Exception ex)
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
                negocio.crearTurno(nuevo);
                Response.Redirect("Horarios.aspx", false);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        

        

        protected void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioPaciente.aspx", false);
        }
    }
}