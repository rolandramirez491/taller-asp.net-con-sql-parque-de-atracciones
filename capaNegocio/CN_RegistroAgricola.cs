using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace capaNegocio
{
    public class CN_RegistroAgricola
    {
        CD_RegistroAgricola Producto = new CD_RegistroAgricola();
        CD_RegistroAgricola Cliente = new CD_RegistroAgricola();
        CD_RegistroAgricola Pedido = new CD_RegistroAgricola();
        CD_RegistroAgricola Pago = new CD_RegistroAgricola();



        ////////////////////////////////////////////produtos///////////////////////////////////////////////

        public void InsertarP(int codProducto, string nombreP, string tipoP,string variedad,int precioP,string unidadDeMed,int stockP,string descripcion,string caracteristicas)
        {
            Producto.InsertarProducto(codProducto, nombreP,tipoP, variedad, precioP, unidadDeMed,stockP, descripcion, caracteristicas);
        }

        public void ActualizarP(int codProducto, string nombreP, string tipoP, string variedad, int precioP, string unidadDeMed, int stockP, string descripcion, string caracteristicas)
        {
            Producto.ActualizarProducto(codProducto, nombreP, tipoP, variedad, precioP, unidadDeMed, stockP, descripcion, caracteristicas);
        }

        public void EliminarP(int codProducto)
        {
            Producto.EliminarProducto(codProducto);
        }

        public DataRow BuscarPN(string nombreP)
        {
            return Producto.BuscarProductoNombre(nombreP);
        }

        public DataRow BuscarPT(string tipoP)
        {
            return Producto.BuscarProductoTipo(tipoP);
        }

        public DataRow BuscarPP(string precioP)
        {
            return Producto.BuscarProductoPrecio(precioP);
        }

        public DataRow BuscarPS(string stockP)
        {
            return Producto.BuscarProductoStock(stockP);
        }

        public DataTable ListarP()
        {
            return Producto.ListarProductos();
        }

        /// //////////////////////////////////cliente//////////////////////////////////////////////////////


        public void InsertarC(int codCliente, string nombre, string contacto, string ubicacion,string tipoDeCliente)
        {
            Cliente.InsertarCliente(codCliente, nombre, contacto, ubicacion, tipoDeCliente);
        }

        public void ActualizarC(int codCliente, string nombre, string contacto, string ubicacion, string tipoDeCliente)
        {
            Cliente.ActualizarCliente(codCliente, nombre, contacto, ubicacion, tipoDeCliente);
        }

        public void EliminarC(int codCliente)
        {
            Cliente.EliminarCliente(codCliente);
        }

        public DataRow BuscarC(int codCliente)
        {
            return Cliente.BuscarCliente(codCliente);
        }

        public DataTable ListarC()
        {
            return Cliente.ListarClientes();
        }

        public DataRow HistoriaPedidoClient(int CodPago)
        {
            return Pedido.HistorialPedidosCliente(CodPago);
        }



        ////////////////////////////////////////pedido////////////////////////////////////////////////////////

        public void InsertarPe(int codPedido,string estado)
        {
            Pedido.InsertarPedido(codPedido, estado);
        }

        public void ActualizarPe(int CodPedido, string Estado)
        {
            Pedido.ActualizarPedido(CodPedido, Estado);
        }

        public void EliminarPe(int codPedido)
        {
            Pedido.EliminarPedido(codPedido);
        }

        public DataRow BuscarPe(int codPedido)
        {
            return Pedido.BuscarPedido(codPedido);
        }

        public DataTable ListarPe()
        {
            return Pedido.ListarPedidos();
        }






        /// //////////////////////////////////////////pagos//////////////////////////////////////////////////////


        public void InsertarPa(int CodPago, string Tipo,int Monto, string Fecha,string Estado)
        {
            Pago.InsertarPago(CodPago, Tipo, Monto, Fecha, Estado);
        }



        public DataRow listPagFech(int CodPago)
        {
            return Pago.ListadoPagosFecha(CodPago);
        }

        public DataRow listPagClient(int CodPago)
        {
            return Pago.ListadoPagosCliente(CodPago);
        }

        public DataRow listPagEstad(int CodPago)
        {
            return Pago.ListadoPagosEstado(CodPago);
        }







        //public void Guardar(int id, string nombre, string apellido, int telefono)
        //{
        //    registro.GuardarRegistro(id, nombre, apellido, telefono);
        //}
        //public void Venta(int id, string nombre,string apellido,int telefono,string fecha, string origen,string destino, int valor)
        //{
        //    ventas.GuardarVenta(id,nombre,apellido,telefono, fecha, origen,destino, valor);
        //}
        //public DataTable Listar()
        //{
        //    return ventas.ListarVentas();
        //}
        //public DataTable Buscar(int id)
        //{
        //    return registro.BuscarCliente(id);
        //}
    }
}
