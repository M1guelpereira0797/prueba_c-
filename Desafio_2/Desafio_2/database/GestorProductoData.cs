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
    internal class GestorProductoDataBase 
    {
        private string connectionString;

        public GestorProductoDataBase()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        }
        public static List<ProductoData> ObtenerProducto(int idProducto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "SELECT  Id, Descripciones, Costo, PrecioVenta From Producto Where  id= @idProducto";
            List<ProductoData> listprodcuto = new List<ProductoData>();
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
                                ProductoData producto = new ProductoData();
                                producto.Id = Convert.ToInt32(dataReader["id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVneta"]);
                                listprodcuto.Add(producto);

                            }
                        }

                    }

                }
                connection.Close();
            }
            return listprodcuto;
        }
        public List<ProductoData> ListarProducto()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "SELECT * From Producto";
            List<ProductoData> listprodcuto = new List<ProductoData>();
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
                                ProductoData producto = new ProductoData();
                                producto.Id = Convert.ToInt32(dataReader["id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVneta"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);
                                listprodcuto.Add(producto);
                            }
                        }
                    }
                }
            }
            return listprodcuto;
        }
        public static void CrearProducto(ProductoData producto )
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "INSERT INTO Producto (Descripcion, Costo, PrecioVenta, Stock, IdUsuario)" +
            "VALUES(@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand crear = new SqlCommand(query, connection))
                {

                    crear.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                    crear.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                    crear.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                    crear.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    crear.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });
                }
                connection.Close();
            }
        }
        public static void ModificarProducto(ProductoData producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = " UPDATE Producto " +
                           " SET Descripcion  " +
                           ", Costo = @Costo " +
                           ", PrecioVenta = @PrecioVenta " +
                           ", Stock = @Stock " +
                           ", IdUsuario = @IdUsuario " +
                           "WHERE Id = @Id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand modificar = new SqlCommand(query, connection))
                {
                    modificar.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    modificar.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                    modificar.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                    modificar.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                    modificar.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    modificar.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });
                    
                }
                connection.Close();
            }
        }
        public static void EliminarProducto(ProductoData producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "DELETE FROM Producto WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand eliminar = new SqlCommand(query, connection))
                {
                    eliminar.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                   
                }
                connection.Close();
            }
        }
    }
    
}
