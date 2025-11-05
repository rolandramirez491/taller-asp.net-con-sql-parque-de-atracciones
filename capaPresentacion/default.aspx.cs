using capaNegocio;
using System;
namespace capaPresentacion
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CN_RegistroAgricola Atraccion = new CN_RegistroAgricola();
        CN_RegistroAgricola registro = new CN_RegistroAgricola();
        //protected void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    registro.Guardar(int.Parse(txtId.Text), txtNomb.Text, txtApell.Text, int.Parse(txtTel.Text));
        //    lblcheck.Text = "Registro guardado con exito!";
        //    txtId.Text = "";
        //    txtNomb.Text = "";
        //    txtApell.Text = "";
        //    txtTel.Text = "";
        //    btnBuscarliente.BackColor = System.Drawing.Color.LightGreen;
        //}

        protected void btnGestionVentas_Click(object sender, EventArgs e)
        {

        }

        //protected void btnListarVentas_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("ListarVentas.aspx");
        //}

        //protected void btnBuscarliente_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("BuscarCliente.aspx");
        //    btnListarVentas.Enabled = true;
        //}

        protected void btnGestionJuegos_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionJuego.aspx");
        }

        protected void btnSesiones_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionSesion.aspx");
        }

        protected void btnGuardarA_Click(object sender, EventArgs e)
        {
            Response.Redirect("Atracciones.aspx");

        }
    }
}