using capaNegocio;
using System;
namespace capaPresentacion
{
    public partial class GestionJuego : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CN_RegistroAtraccion Juego = new CN_RegistroAtraccion();
        //CN_RegistroAtraccion registro = new CN_RegistroAtraccion();
        //CN_RegistroAtraccion ventas = new CN_RegistroAtraccion();
        //protected void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    int id = int.Parse(txtId.Text);

        //    dgvBuscar.DataSource = null;
        //    dgvBuscar.DataSource = registro.Buscar(id);
        //    dgvBuscar.DataBind();

        //    if (dgvBuscar.Rows.Count>0)
        //    {
        //    lblError.Text = "";
        //        lblFecha.Visible = true;
        //    lblOrigen.Visible = true;
        //    lblDestino.Visible = true;
        //    lblValor.Visible = true;
        //    txtFecha.Visible = true;
        //    txtOrigen.Visible = true;
        //    txtDestino.Visible = true;
        //    txtValor.Visible = true;
        //    btnRegistrar.Visible = true;
        //    }
        //    else
        //    {
        //        lblError.Text="Cliente no encontrado";
        //    }
        //}

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        //protected void btnRegistrar_Click(object sender, EventArgs e)
        //{
        //    GridViewRow fila = dgvBuscar.Rows[0];

        //    string nombre = fila.Cells[1].Text;
        //    string apellido = fila.Cells[2].Text;
        //    int telefono = int.Parse(fila.Cells[3].Text); 

        //    ventas.Venta(int.Parse(txtId.Text), nombre, apellido, telefono, txtFecha.Text, txtOrigen.Text, txtDestino.Text, int.Parse(txtValor.Text));
        //    lblExito.Text = "Venta registrada con exito!";
        //    txtId.Text = "";
        //    txtFecha.Text = "";
        //    txtOrigen.Text = "";
        //    txtDestino.Text = "";
        //    txtValor.Text = "";
        //    btnAtras.Enabled = true;
        //    btnAtras.BackColor = System.Drawing.Color.LightGreen;
        //}

        protected void btnGuardarJuego_Click(object sender, EventArgs e)
        {
            Juego.InsertarJ(int.Parse(txtCodJ.Text), txtNombreJ.Text, int.Parse(txtDuracion.Text), txtCategoria.Text);
            lblCheck.Text = "Juego guardado con exito!";
            txtCodJ.Text = "";
            txtNombreJ.Text = "";
            txtDuracion.Text = "";
            txtCategoria.Text = "";
        }
    }
}