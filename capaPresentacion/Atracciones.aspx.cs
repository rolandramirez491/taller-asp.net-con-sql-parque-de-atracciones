using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;
namespace capaPresentacion
{
    public partial class Atracciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CN_RegistroAtraccion Atraccion = new CN_RegistroAtraccion();
        protected void btnGuardarA_Click(object sender, EventArgs e)
        {
            Atraccion.InsertarA(int.Parse(txtCodA.Text), txtNombA.Text, int.Parse(txtPrecio.Text), int.Parse(txtCapacidad.Text));
            lblcheck.Text = "Atraccion guardada con exito!";
            txtCodA.Text = "";
            txtNombA.Text = "";
            txtPrecio.Text = "";
            txtCapacidad.Text = "";
            btnAtras.BackColor = System.Drawing.Color.LightGreen;

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCodA.Text = "";
            txtNombA.Text = "";
            txtPrecio.Text = "";
            txtCapacidad.Text = "";

                ddlAtracciones.DataSource = Atraccion.ListarA();
                ddlAtracciones.DataTextField = "NombreA";
                ddlAtracciones.DataValueField = "CodA";
                ddlAtracciones.DataBind();
                ddlAtracciones.Items.Insert(0, new ListItem("--Seleccione Atracción A Buscar--", ""));
                ddlAtracciones.BackColor = System.Drawing.Color.LightGreen;




        }

        protected void ddlAtracciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlAtracciones.SelectedValue))
            {
                int CodA = int.Parse(ddlAtracciones.SelectedValue);
                var Busqueda=Atraccion.BuscarA(CodA);
                if (Busqueda != null)
                {
                    txtCodA.Text = Busqueda["CodA"].ToString();
                    txtNombA.Text = Busqueda["NombreA"].ToString();
                    txtPrecio.Text = Busqueda["Precio"].ToString();
                    txtCapacidad.Text = Busqueda["Capacidad"].ToString();
                    btnActualizar.Visible = true;
                    btnActualizar.BackColor = System.Drawing.Color.BurlyWood;
                    btnGuardarA.Enabled = false;
                    txtCodA.BackColor= System.Drawing.Color.Cyan;
                    txtNombA.BackColor = System.Drawing.Color.Cyan;
                    txtPrecio.BackColor = System.Drawing.Color.Cyan;
                    txtCapacidad.BackColor = System.Drawing.Color.Cyan;
                }
                else
                {
                    lblCodA.Text = "Atracción no encontrada";
                    ddlAtracciones.BackColor = System.Drawing.Color.Red;
                }
                }
            else
            {
                lblCodA.Text = "Ninguno seleccionado";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            btnActualizar.Visible = false;
            btnGuardarA.Enabled = true;
            txtCodA.BackColor = System.Drawing.Color.LightGreen;
            txtNombA.BackColor = System.Drawing.Color.LightGreen;
            txtPrecio.BackColor = System.Drawing.Color.LightGreen;
            txtCapacidad.BackColor = System.Drawing.Color.LightGreen;
            btnActualizar.BorderColor= System.Drawing.Color.LightGreen;
            Atraccion.ActualizarA(int.Parse(txtCodA.Text), txtNombA.Text, int.Parse(txtPrecio.Text), int.Parse(txtCapacidad.Text));
            txtCodA.Text = "";
            txtNombA.Text = "";
            txtPrecio.Text = "";
            txtCapacidad.Text = "";

            ddlAtracciones.DataSource = Atraccion.ListarA();
            ddlAtracciones.DataTextField = "NombreA";
            ddlAtracciones.DataValueField = "CodA";
            ddlAtracciones.DataBind();
            ddlAtracciones.Items.Insert(0, new ListItem("--Seleccione Atracción A Buscar--", ""));
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}