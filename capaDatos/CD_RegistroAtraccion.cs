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
    public class CD_RegistroAtraccion
    {
        private static readonly string cadena =ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        //private static List<string> registro = new List<string>();
        //private static List<string> registroV = new List<string>();

        public void InsertarAtraccion(int codA, string nombreA, int precio, int capacidad)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarAtraccion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodA", codA);
                comando.Parameters.AddWithValue("@NombreA", nombreA);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Parameters.AddWithValue("@Capacidad", capacidad);

                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void ActualizarAtraccion(int codA, string nombreA, int precio, int capacidad)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ActualizarAtraccion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodA", codA);
                comando.Parameters.AddWithValue("@NombreA", nombreA);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Parameters.AddWithValue("@Capacidad", capacidad);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarAtraccion(int codA)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_EliminarAtraccion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodA", codA);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public DataRow BuscarAtraccion(int codA)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarAtraccion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodA", codA);
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

        public DataTable ListarAtracciones()
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ListarAtracciones", cn);
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

        //////////////////////////////////////////////////juegos//////////////////////////////////////////////////////////

        public void InsertarJuego(int codJ, string nombreJ, int duracion, string categoria)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarJuego", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodJ", codJ);
                comando.Parameters.AddWithValue("@NombreJ", nombreJ);
                comando.Parameters.AddWithValue("@Duracion", duracion);
                comando.Parameters.AddWithValue("@Categoria", categoria);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void ActualizarJuego(int codJ, string nombreJ, int duracion, string categoria)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ActualizarJuego", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodJ", codJ);
                comando.Parameters.AddWithValue("@NombreJ", nombreJ);
                comando.Parameters.AddWithValue("@Duracion", duracion);
                comando.Parameters.AddWithValue("@Categoria", categoria);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarJuego(int codJ)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_EliminarJuego", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodJ", codJ);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public DataRow BuscarJuego(int codJ)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarJuego", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodJ", codJ);
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

        public DataTable ListarJuegos()
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ListarJuegos", cn);
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


        /// ///////////////////////////////////////////////////sesion/////////////////////////////////////////////////////////////
        
        public void InsertarSesion(int idSesion, int codA, int codJ, int numeroZona,int hora, int boletos)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarSesion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdSesion", idSesion);
                comando.Parameters.AddWithValue("@CodA", codA);
                comando.Parameters.AddWithValue("@CodJ", codJ);
                comando.Parameters.AddWithValue("@NumeroZona", numeroZona);
                comando.Parameters.AddWithValue("@Hora", hora);
                comando.Parameters.AddWithValue("@Boletos", boletos);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void ActualizarSesion(int idSesion, int codA, int codJ, int numeroZona, int hora, int boletos)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ActualizarSesion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdSesion", idSesion);
                comando.Parameters.AddWithValue("@CodA", codA);
                comando.Parameters.AddWithValue("@CodJ", codJ);
                comando.Parameters.AddWithValue("@NumeroZona", numeroZona);
                comando.Parameters.AddWithValue("@Hora", hora);
                comando.Parameters.AddWithValue("@Boletos", boletos);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarSesion(int idSesion)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_EliminarSesion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdSesion", idSesion);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }

        public DataRow BuscarSesion(int idSesion)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarSesion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdSesion", idSesion);
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

        public DataTable ListarSesiones()
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ListarSesiones", cn);
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


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
