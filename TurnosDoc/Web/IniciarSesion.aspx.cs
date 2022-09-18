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
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            User usuario = new User();
            UserNegocio negocio = new UserNegocio();
            try
            {
                usuario.Usuario = txtEmail.Text;
                usuario.Pass = txtPass.Text;
                bool verificar = negocio.verificarConSP(usuario);
                if (verificar)
                {
                    Session["usuarioLog"] = txtEmail.Text;
                    Response.Redirect("~/Administracion/Horarios.aspx", false);
                }
                else
                {
                    if (txtEmail.Text == "" || txtPass.Text == "")
                        lblUserDanger.Text = "Ingrese su usuario y contraseña";
                    else
                        lblUserDanger.Text = "Usuario o contraseña incorrecta";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}