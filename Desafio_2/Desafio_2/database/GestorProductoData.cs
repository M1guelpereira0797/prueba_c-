using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Desafio_2.models;

namespace Desafio_2.database
{
    public class GestorProductoDataBase 
    {
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
        
       
    }
    
}
