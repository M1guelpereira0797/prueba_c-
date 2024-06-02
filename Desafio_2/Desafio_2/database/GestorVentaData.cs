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
        public static void CrearUsuarioData(VentaData venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contrasena, Mail)" +
            "VALUES(@Nombre, @Apellido, @NombreUsuario, @Contrasena , @Mail)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand crear = new SqlCommand(query, connection))
                {

                    crear.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = venta.Id});
                    crear.Parameters.Add(new SqlParameter("Apellido", SqlDbType.Money) { Value = venta.Comentarios });
                    crear.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.Int) { Value = venta.idUsuario });
                    crear.Parameters.Add(new SqlParameter("Contrasena", SqlDbType.VarChar) { Value = usuario.Contrasena });
                    crear.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                }
                connection.Close();
            }
        }
        public static void ModificarUsuarioData(UsuarioData usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = " UPDATE Usuario" +
                           " SET Nombre  " +
                           ", Apellido = @Apellido " +
                           ", NombreUsuario = @NombreUsuario " +
                           ", Contrasena = @Contrasena " +
                           ", Mail = @Mail " +
                           "WHERE Id = @Id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand modificar = new SqlCommand(query, connection))
                {
                    modificar.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                    modificar.Parameters.Add(new SqlParameter("Nombre", SqlDbType.Int) { Value = usuario.Nombre });
                    modificar.Parameters.Add(new SqlParameter("Apellido", SqlDbType.Money) { Value = usuario.Apellido });
                    modificar.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    modificar.Parameters.Add(new SqlParameter("Contrasena", SqlDbType.VarChar) { Value = usuario.Contrasena });
                    modificar.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });


                }
                connection.Close();
            }
        }
        public static void EliminarUsuarioData(UsuarioData usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "DELETE FROM Usuario WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand eliminar = new SqlCommand(query, connection))
                {
                    eliminar.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });

                }
                connection.Close();
            }
        }
    }
}
