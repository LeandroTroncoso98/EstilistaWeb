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
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    GeneroNegocio negocioGenero = new GeneroNegocio();
                    List<Sexo> listaGenero = negocioGenero.listar();
                    ddlGenero.DataSource = listaGenero;
                    ddlGenero.DataValueField = "Id";
                    ddlGenero.DataTextField = "Sexualidad";
                    ddlGenero.DataBind();
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
                dominio.Paciente nuevo = new dominio.Paciente();
                PacienteNegocio negocio = new PacienteNegocio();
                nuevo.NombreCompleto = txtNombre.Text + " " + txtApellido.Text;
                nuevo.Edad = int.Parse(txtEdad.Text);
                nuevo.sexo = new Sexo();
                nuevo.sexo.Id = int.Parse(ddlGenero.SelectedValue);
                nuevo.Email = txtEmail.Text;
                nuevo.Celular = txtCelular.Text;
                negocio.CrearPacienteSP(nuevo);
                Response.Redirect("Clientes.aspx", false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}