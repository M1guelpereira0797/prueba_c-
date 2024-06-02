using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Desafio_2.models;
using System.Data;

namespace Desafio_2.database
{
    internal class GestorVentaData
    {

        private string connectionString;

        public GestorVentaData()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        }

        public static List<VentaData> ObtenerVentaData(string idusuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "SELECT  Id, Comentario, IdUsuario From Usuario Where  id= @idusuario";
            List<VentaData> listprodcuto = new List<VentaData>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                VentaData producto = new VentaData();
                                producto.Id = Convert.ToInt32(dataReader["id"]);
                                producto.Comentarios = dataReader[" Comentario "].ToString();
                                producto.idUsuario = dataReader["id Usuario"].ToString();
                                listprodcuto.Add(producto);

                            }
                        }

                    }

                }
                connection.Close();
            }
            return listprodcuto;
        }
        public List<VentaData> ListarVentaData()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "SELECT * From Producto";
            List<VentaData> listprodcuto = new List<VentaData>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                VentaData producto = new VentaData();
                                producto.Id = Convert.ToInt32(dataReader["id"]);
                                producto.Comentarios = dataReader[" Comentario "].ToString();
                                producto.idUsuario = dataReader["id Usuario"].ToString();
                                listprodcuto.Add(producto);
                            }
                        }
                    }
                }
            }
            return listprodcuto;
        }
        public static void CrearVentaData(VentaData venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "INSERT INTO Producto (ID, Comentarios, IdUsuario)" +
            "VALUES(@ID, @Comentarios, @IdUsuario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand crear = new SqlCommand(query, connection))
                {

                    crear.Parameters.Add(new SqlParameter(" Id ", SqlDbType.VarChar) { Value = venta.Id});
                    crear.Parameters.Add(new SqlParameter(" Comentarios ", SqlDbType.Money) { Value = venta.Comentarios });
                    crear.Parameters.Add(new SqlParameter("Id Usuario", SqlDbType.Int) { Value = venta.idUsuario });
                  
                }
                connection.Close();
            }
        }
        public static void ModificarVentaData(VentaData venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = " UPDATE Id" +
                           " SET Comentarios  " +
                           ", IdUsuario = @IdUsuario " +
                           "WHERE Id = @Id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand modificar = new SqlCommand(query, connection))
                {
                    modificar.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value =venta.Id });
                    modificar.Parameters.Add(new SqlParameter(" Comentarios ", SqlDbType.Int) { Value = venta.Comentarios });
                    modificar.Parameters.Add(new SqlParameter(" IdUsuario ", SqlDbType.Money) { Value = venta.idUsuario });
                    


                }
                connection.Close();
            }
        }
        public static void EliminarVentaData(VentaData venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "DELETE FROM Producto WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand eliminar = new SqlCommand(query, connection))
                {
                    eliminar.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });

                }
                connection.Close();
            }
        }
    }
}
