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
                    GeneroNegocio negocioGenero = new GeneroNegocio();
                    List<Sexo> listaGenero = negocioGenero.listar();
                    ddlGenero.DataSource = listaGenero;
                    ddlGenero.DataValueField = "Id";
                    ddlGenero.DataTextField = "Sexualidad";
                    ddlGenero.DataBind();
                }
                string id = TomaId();
                if (id != "" && !IsPostBack)
                {
                    PacienteNegocio negocio = new PacienteNegocio();
                    dominio.Paciente seleccionado = (negocio.SelectItemFromId(id));
                    if (seleccionado != null)
                    {
                        txtId.Text = seleccionado.id.ToString();
                        txtNombreCompleto.Text = seleccionado.NombreCompleto;
                        txtEdad.Text = seleccionado.Edad.ToString();
                        txtEmail.Text = seleccionado.Email;
                        txtCelular.Text = seleccionado.Celular;
                        ddlGenero.SelectedValue = seleccionado.sexo.Id.ToString();
                        btnCrear.Text = "modificar";
                        btnEliminar.Visible = true;
                    }
                    else
                        Response.Redirect("Horarios.aspx",true);
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
                nuevo.NombreCompleto = txtNombreCompleto.Text;
                nuevo.Edad = int.Parse(txtEdad.Text);
                nuevo.sexo = new Sexo();
                nuevo.sexo.Id = int.Parse(ddlGenero.SelectedValue);
                nuevo.Email = txtEmail.Text;
                nuevo.Celular = txtCelular.Text;

                if (Request.QueryString["id"] != null)
                {
                    nuevo.id = int.Parse(Request.QueryString["id"].ToString());
                    negocio.ModificarPaciente(nuevo);
                }
                else
                    negocio.CrearPacienteSP(nuevo);
                Response.Redirect("ListaPacientes.aspx", false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteNegocio negocio = new PacienteNegocio();
                int id = int.Parse(txtId.Text);
                negocio.EliminarPaciente(id);
                Response.Redirect("ListaPacientes.aspx", false);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            string id = TomaId();
            if (id == "" || id == null)
                Response.Redirect("ListaPacientes.aspx");
            else
                Response.Redirect("ResumenDeCliente.aspx?id=" + id);
        }
    }
}