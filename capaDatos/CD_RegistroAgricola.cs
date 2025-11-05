using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace capaDatos
{
    public class CD_RegistroAgricola
    {
        private static readonly string cadena =ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        //private static List<string> registro = new List<string>();
        //private static List<string> registroV = new List<string>();

        public void InsertarProducto(int codProducto, string nombreP, string tipoP, string variedad, int precioP, string unidadDeMed, int stockP, string descripcion, string caracteristicas)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarProductos", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodProducto", codProducto);
                comando.Parameters.AddWithValue("@NombreP", nombreP);
                comando.Parameters.AddWithValue("@TipoP", tipoP);
                comando.Parameters.AddWithValue("@Variedad", variedad);
                comando.Parameters.AddWithValue("@PrecioP", precioP);
                comando.Parameters.AddWithValue("@UnidadDeMed", unidadDeMed);
                comando.Parameters.AddWithValue("@StockP", stockP);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@Caracteristicas", caracteristicas);

                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void ActualizarProducto(int codProducto, string nombreP, string tipoP, string variedad, int precioP, string unidadDeMed, int stockP, string descripcion, string caracteristicas)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ActualizarProductos", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodProducto", codProducto);
                comando.Parameters.AddWithValue("@NombreP", nombreP);
                comando.Parameters.AddWithValue("@TipoP", tipoP);
                comando.Parameters.AddWithValue("@Variedad", variedad);
                comando.Parameters.AddWithValue("@PrecioP", precioP);
                comando.Parameters.AddWithValue("@UnidadDeMed", unidadDeMed);
                comando.Parameters.AddWithValue("@StockP", stockP);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@Caracteristicas", caracteristicas);

                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(int codProducto)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_EliminarProductos", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodProducto", codProducto);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public DataRow BuscarProductoNombre(string nombreP)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarProductoNombre", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreP", nombreP);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public DataRow BuscarProductoTipo(string tipoP)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarProductoTipo", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@TipoP", tipoP);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public DataRow BuscarProductoPrecio(string precioP)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarProductoPrecio", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@PrecioP", precioP);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public DataRow BuscarProductoStock(string stockP)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarProductoStock", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@StockP", stockP);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }



        public DataTable ListarProductos()
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ListarProductos", cn);
                comando.CommandType = CommandType.StoredProcedure;
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //////////////////////////////////////////////////clientes//////////////////////////////////////////////////////////

        public void InsertarCliente(int codCliente, string nombre, string contacto, string ubicacion, string tipoDeCliente)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarCliente", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodCliente", codCliente);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Contacto", contacto);
                comando.Parameters.AddWithValue("@Ubicacion", ubicacion);
                comando.Parameters.AddWithValue("@TipoDeCliente", tipoDeCliente);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void ActualizarCliente(int codCliente, string nombre, string contacto, string ubicacion, string tipoDeCliente)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ActualizarCliente", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodCliente", codCliente);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Contacto", contacto);
                comando.Parameters.AddWithValue("@Ubicacion", ubicacion);
                comando.Parameters.AddWithValue("@TipoDeCliente", tipoDeCliente);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarCliente(int codCliente)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_EliminarJuego", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodCLiente", codCliente);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public DataRow BuscarCliente(int codCliente)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarCliente", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodCliente", codCliente);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public DataTable ListarClientes()
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ListarClintes", cn);
                comando.CommandType = CommandType.StoredProcedure;
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataRow HistorialPedidosCliente(int codCliente)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarClienteOinforme", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodCliente", codCliente);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }



        /// ///////////////////////////////////////////////////Pedidos/////////////////////////////////////////////////////////////

        public void InsertarPedido(int codPedido, string estado)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarPedidos", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodPedido", codPedido);
                comando.Parameters.AddWithValue("@Estado", estado);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void ActualizarPedido(int codPedido, string estado)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ActualizarPedido", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodPedido", codPedido);
                comando.Parameters.AddWithValue("@Estado", estado);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarPedido(int codPedido)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_EliminarPedido", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodPedido", codPedido);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public DataRow BuscarPedido(int codPedido)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarPedido", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodPedido", codPedido);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public DataTable ListarPedidos()
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ListarPedidos", cn);
                comando.CommandType = CommandType.StoredProcedure;
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        /////////////////////////////////////////////////////////////pagos////////////////////////////////////////////////////////////

        public void InsertarPago(int codPago, string tipo, int monto, string fecha, string estado)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarPago", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodPago", codPago);
                comando.Parameters.AddWithValue("@Tipo", tipo);
                comando.Parameters.AddWithValue("@Monto", monto);
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@Estado", estado);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }


        public DataRow ListadoPagosFecha(int codPago)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_FiltroFecha", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodPago", codPago);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public DataRow ListadoPagosCliente(int codPago)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_FiltroCliente", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodPago", codPago);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public DataRow ListadoPagosEstado(int codPago)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_FiltroEstado", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodPago", codPago);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    return null;
                }
            }
        }






        //public void GuardarRegistro(int id,string nombre,string apellido,int telefono)
        //{
        //    registro.Add($"ID: {id}, Nombre: {nombre}, Apellido: {apellido}, Teléfono: {telefono}");
        //}
        //public void GuardarVenta(int id, string nombre,string apellido,int telefono,string fecha, string origen,string destino, int valor)
        //{
        //    registroV.Add($"ID: {id},Nombre: {nombre},Apellido: {apellido},Telefono: {telefono}, Fecha: {fecha}, Origen: {origen},Destino: {destino}, Valor: {valor}");
        //}
        //public DataTable ListarVentas()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Id", typeof(int));
        //    dt.Columns.Add("Nombre", typeof(string));
        //    dt.Columns.Add("Apellido", typeof(string));
        //    dt.Columns.Add("Telefono", typeof(int));
        //    dt.Columns.Add("Fecha", typeof(string));
        //    dt.Columns.Add("Origen", typeof(string));
        //    dt.Columns.Add("Destino", typeof(string));
        //    dt.Columns.Add("Valor", typeof(int));
        //    foreach (string linea in registroV)
        //    {
        //        // Dividir la cadena por el separador (coma, punto y coma, etc.)
        //        string[] campos = linea.Split(','); // Cambiar separador según tu formato

        //        // Verificar que tenga exactamente 8 campos
        //        if (campos.Length == 8)
        //        {
        //            DataRow fila = dt.NewRow();
        //            fila["Id"] = int.Parse(campos[0].Trim().Split(':')[1]);
        //            fila["Nombre"] = campos[1].Trim();
        //            fila["Apellido"] = campos[2].Trim();
        //            fila["Telefono"] = int.Parse(campos[3].Trim().Split(':')[1]);
        //            fila["Fecha"] = campos[4].Trim();
        //            fila["Origen"] = campos[5].Trim();
        //            fila["Destino"] = campos[6].Trim();
        //            fila["Valor"] = int.Parse(campos[7].Trim().Split(':')[1]);

        //            dt.Rows.Add(fila);
        //        }
        //    }

        //    return dt;

        //}
        //public DataTable BuscarCliente(int idFind)
        //{
        //    // Crear DataTable con las columnas necesarias


        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Id", typeof(int));
        //    dt.Columns.Add("Nombre", typeof(string));
        //    dt.Columns.Add("Apellido", typeof(string));
        //    dt.Columns.Add("Telefono", typeof(int));
        //    foreach (string linea in registro)
        //    {
        //        // Dividir la cadena por el separador (coma, punto y coma, etc.)
        //        string[] campos = linea.Split(','); // Cambiar separador según tu formato

        //        // Verificar que tenga exactamente 5 campos
        //        if (campos.Length == 4)
        //        {
        //            DataRow fila = dt.NewRow();
        //            fila["Id"] = int.Parse(campos[0].Trim().Split(':')[1]);
        //            fila["Nombre"] = campos[1].Trim();
        //            fila["Apellido"] = campos[2].Trim();
        //            fila["Telefono"] = int.Parse(campos[3].Trim().Split(':')[1]);

        //            dt.Rows.Add(fila);
        //        }
        //    }
        //    DataRow[] filasFiltradas = dt.Select($"Id = {idFind}");
        //    DataTable dtFiltrado = dt.Clone();
        //    foreach (DataRow fila in filasFiltradas)
        //    {
        //        dtFiltrado.ImportRow(fila);
        //    }
        //    return dtFiltrado;
        //}
    }
}
