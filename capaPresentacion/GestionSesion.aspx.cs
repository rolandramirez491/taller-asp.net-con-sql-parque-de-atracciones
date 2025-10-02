using capaNegocio;
using System;
using System.Web.UI.WebControls;

namespace capaPresentacion
{
    public partial class GestionSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)               // ← Importante
            {
                ddlCodA.DataSource = Atraccion.ListarA();
                ddlCodA.DataTextField = "CodA";
                ddlCodA.DataValueField = "CodA";
                ddlCodA.DataBind();
                ddlCodA.Items.Insert(0, new ListItem("--Seleccione Atracción--", ""));

                ddlCodJ.DataSource = Juego.ListarJ();
                ddlCodJ.DataTextField = "CodJ";
                ddlCodJ.DataValueField = "CodJ";
                ddlCodJ.DataBind();
                ddlCodJ.Items.Insert(0, new ListItem("--Seleccione Juego--", ""));
            }
        }
        CN_RegistroAtraccion Atraccion = new CN_RegistroAtraccion();
        CN_RegistroAtraccion Juego = new CN_RegistroAtraccion();
        CN_RegistroAtraccion Sesion = new CN_RegistroAtraccion();



        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnGuardarSesion_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(ddlCodA.SelectedValue) && !string.IsNullOrEmpty(ddlCodJ.SelectedValue))
            {

                // Convertir los valores seleccionados a int
                int codA = int.Parse(ddlCodA.SelectedValue);
                int codJ = int.Parse(ddlCodJ.SelectedValue);

                // Llamar al método InsertarS con los valores correctos
                Sesion.InsertarS(
                    int.Parse(txtIdSesion.Text),
                    codA,
                    codJ,
                    int.Parse(txtNumZona.Text),
                    int.Parse(txtHora.Text),
                    int.Parse(txtBoletos.Text)
                );
            }
            else
            {
                // Mostrar mensaje de error si no hay selección
                lblCheck.Text = "Por favor, seleccione un código de atracción y de juego.";
                btnGuardarSesion.BackColor = System.Drawing.Color.Red;
            }

        }

        protected void rbtCodJ_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnGuardarSesion.BackColor = System.Drawing.Color.DarkOrange;
        }

        protected void txtBoletos_TextChanged(object sender, EventArgs e)
        {
            btnGuardarSesion.BackColor = System.Drawing.Color.DarkGreen;
            btnGuardarSesion.Enabled = true;
        }


    }
}