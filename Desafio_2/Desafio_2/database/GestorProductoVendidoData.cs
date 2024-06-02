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
    internal class GestorProductoVendidoData
    { 
    
        private string connectionString;

        public GestorProductoVendidoData()
        {
        connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        }
    
        public static List<ProductoVendidoData> ObtenerProductoVendido(int idProducto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "SELECT  Id, idProducto, Stock, idVenta From Producto Where  id= @idProducto";
            List<ProductoVendidoData> listprodcuto = new List<ProductoVendidoData>();
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
                                ProductoVendidoData producto = new ProductoVendidoData();
                                producto.Id = Convert.ToInt32(dataReader["id"]);
                                producto.idProducto = Convert.ToInt32(dataReader["id Producto"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock "]);
                                producto.idVenta = Convert.ToInt32(dataReader["id Vneta"]);
                                listprodcuto.Add(producto);

                            }
                        }

                    }

                }
                connection.Close();
            }
            return listprodcuto;
        }
        public List<ProductoVendidoData> ListarProductoVendido()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
            string query = "SELECT * From Producto";
            List<ProductoVendidoData> listprodcuto = new List<ProductoVendidoData>();
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
                                ProductoVendidoData producto = new ProductoVendidoData();
                                producto.Id = Convert.ToInt32(dataReader["id"]);
                                producto.idProducto = Convert.ToInt32(dataReader["id Producto"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock "]);
                                producto.idVenta = Convert.ToInt32(dataReader["id Vneta"]);
                                listprodcuto.Add(producto);
                            }
                        }
                    }
                }
            }
            return listprodcuto;
        }
      
        public static void ModificarProductoVendido(ProductoVendidoData producto)
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
                    modificar.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    modificar.Parameters.Add(new SqlParameter("idVenta", SqlDbType.Money) { Value = producto.idVenta });
                    modificar.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = producto.idProducto });

                }
                connection.Close();
            }
        }
        public static void EliminarProductoVendido(ProductoVendidoData producto)
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
