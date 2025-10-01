using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace capaNegocio
{
    public class CN_RegistroAtraccion
    {
        CD_RegistroAtraccion Atraccion = new CD_RegistroAtraccion();
        CD_RegistroAtraccion Juego = new CD_RegistroAtraccion();
        CD_RegistroAtraccion Sesion = new CD_RegistroAtraccion();
        //CD_RegistroAtraccion registro = new CD_RegistroAtraccion();
        //CD_RegistroAtraccion ventas = new CD_RegistroAtraccion();

        ////////////////////////////////////////////Atracciones///////////////////////////////////////////////

        public void InsertarA(int codA, string nombre, int precio,int capacidad)
        {
            Atraccion.InsertarAtraccion(codA,nombre, precio,capacidad);
        }

        public void ActualizarA(int codA, string nombre, int precio, int capacidad)
        {
            Atraccion.ActualizarAtraccion(codA, nombre, precio, capacidad);
        }

        public void EliminarA(int codA)
        {
            Atraccion.EliminarAtraccion(codA);
        }

        public DataRow BuscarA(int codA)
        {
            return Atraccion.BuscarAtraccion(codA);
        }

        public DataTable ListarA()
        {
            return Atraccion.ListarAtracciones();
        }


        /// //////////////////////////////////juego//////////////////////////////////////////////////////
        

        public void InsertarJ(int codJ, string nombre, int duracion, string categoria)
        {
            Juego.InsertarJuego(codJ, nombre, duracion, categoria);
        }

        public void ActualizarJ(int codJ, string nombre, int duracion, string categoria)
        {
            Juego.ActualizarJuego(codJ, nombre, duracion, categoria);
        }

        public void EliminarJ(int codJ)
        {
            Juego.EliminarJuego(codJ);
        }

        public DataRow BuscarJ(int codJ)
        {
            return Juego.BuscarJuego(codJ);
        }

        public DataTable ListarJ()
        {
            return Juego.ListarJuegos();
        }
        ////////////////////////////////////////sesion////////////////////////////////////////////////////////
        
        public void InsertarS(int idSesion,int codA,int codJ,int numeroZona,int hora,int boletos)
        {
            Sesion.InsertarSesion(idSesion,codA,codJ,numeroZona,hora,boletos);
        }

        public void ActualizarS(int idSesion, int codA, int codJ, int numeroZona, int hora, int boletos)
        {
            Sesion.ActualizarSesion(idSesion, codA, codJ, numeroZona, hora, boletos);
        }

        public void EliminarS(int idSesion)
        {
            Sesion.EliminarSesion(idSesion);
        }

        public DataRow BuscarS(int idSesion)
        {
            return Sesion.BuscarSesion(idSesion);
        }

        public DataTable ListarS()
        {
            return Sesion.ListarSesiones();
        }






        /// ////////////////////////////////////////////////////////////////////////////////////////////////





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
