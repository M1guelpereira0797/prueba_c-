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
    internal class GestorUsuarioData
    {

        private string connectionString;

        public GestorUsuarioData()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        }

        public static List<UsuarioData> ObtenerUsuarioData(string idusuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "SELECT  Id, Nombre, Apellido, NombreUsuario, Contrasena, Mail From Usuario Where  id= @idusuario";
            List<UsuarioData> listprodcuto = new List<UsuarioData>();
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
                                UsuarioData producto = new UsuarioData();
                                producto.Id = Convert.ToInt32(dataReader["id"]);
                                producto.Nombre = dataReader[" Nombre "].ToString();
                                producto.Apellido= dataReader[" Apellido "].ToString();
                                producto.NombreUsuario = dataReader[" Nombre Usuario "].ToString();
                                producto.Contrasena = Convert.ToInt32(dataReader["id Vneta"]);
                                producto.Mail =dataReader["id Vneta"].ToString();
                                listprodcuto.Add(producto);

                            }
                        }

                    }

                }
                connection.Close();
            }
            return listprodcuto;
        }
        public List<UsuarioData> ListarUsuarioData()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "SELECT * From Usuario";
            List<UsuarioData> listprodcuto = new List<UsuarioData>();
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
                                UsuarioData producto = new UsuarioData();
                                producto.Id = Convert.ToInt32(dataReader["id"]);
                                producto.Nombre = dataReader[" Nombre "].ToString();
                                producto.Apellido = dataReader[" Apellido "].ToString();
                                producto.NombreUsuario = dataReader[" Nombre Usuario "].ToString();
                                producto.Contrasena = Convert.ToInt32(dataReader[" Contrasena "]);
                                producto.Mail = dataReader[" Mail "].ToString();
                                listprodcuto.Add(producto);
                            }
                        }
                    }
                }
            }
            return listprodcuto;
        }
        public static void CrearUsuarioData(UsuarioData usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contrasena, Mail)" +
            "VALUES(@Nombre, @Apellido, @NombreUsuario, @Contrasena , @Mail)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand crear = new SqlCommand(query, connection))
                {

                    crear.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    crear.Parameters.Add(new SqlParameter("Apellido", SqlDbType.Money) { Value = usuario.Apellido });
                    crear.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.Int) { Value = usuario.NombreUsuario });
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
