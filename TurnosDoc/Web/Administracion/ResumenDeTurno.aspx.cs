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
    public partial class ResumenDeTurno : System.Web.UI.Page
    {
        public bool checkeo = true;
        
        private string TomaId()
        {
            string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
            return id;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            string id = TomaId();
            checkeo = false;
            if (id == "")
            {
                Response.Redirect("Horarios.aspx");
            }
            else
            {
                try
                {
                    Turno aux = negocio.SelectItemFromId(id);

                    if (aux != null)
                    {
                        if (!IsPostBack)
                        {
                            lblNombreCompleto.Text += aux.paciente.NombreCompleto;
                            lblEdad.Text += aux.paciente.Edad.ToString();
                            lblCelular.Text += aux.paciente.Celular;
                            lblSexo.Text += aux.paciente.sexo.Sexualidad;
                            lblFecha.Text += aux.fecha;
                            lblHorario.Text += aux.hora.Horario;
                            lblTratamiento.Text += aux.tratamiento.Descripcion;
                            txtDescripcion.Text = aux.Descripcion;
                                                  }
                        if (checkEliminar.Checked)
                            checkeo = true;
                    }
                    else
                        Response.Redirect("Horarios.aspx");

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TurnoNegocio negocio = new TurnoNegocio();
                negocio.EliminarTurno(int.Parse(TomaId()));
                Response.Redirect("Horarios.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnModificarTurno_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioTurno.aspx?id=" + int.Parse(TomaId()));
        }

        protected void btnAgregarDesc_Click(object sender, EventArgs e)
        {
            try
            {
                TurnoNegocio turnoNegocio = new TurnoNegocio();
                turnoNegocio.modificarDescripcion(int.Parse(TomaId()), txtDescripcion.Text);
                Response.Redirect("Horarios.aspx");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        

        protected void btnWAppp_Click(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            string nombre, celular, fecha, horario, tratamiento;
            try
            {
                Turno turno = negocio.SelectItemFromId(TomaId());
                nombre = turno.paciente.NombreCompleto;
                celular = turno.paciente.Celular;
                fecha = turno.fecha;
                horario = turno.hora.Horario.ToString();
                tratamiento = turno.tratamiento.Descripcion;
                string url = "https://wa.me/549" + celular + "?text=Hola%20" + nombre.Replace(" ", "%20")
                    + ".%20Recuerde%20que%20el%20día%20" 
                    + fecha + "%20a%20las%20" + horario + "%20tiene%20turno%20para%20realizarse%20"
                    + tratamiento.Replace(" ", "%20") + ",%20saludos!";
                Response.Redirect(url);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}