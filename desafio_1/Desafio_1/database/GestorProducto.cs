using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Desafio_1.models;


namespace Desafio_1.database
{
    public class GestorProducto
    {
        string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Desafio_1; Trusted_Connection=True";
        string query = "SELECT * FOM Id, Descripciones, Costa, PrecioVenta from Producto";
        List<Producto> listprodcuto = new List<Producto>();
            using (Sqlconnection connection = new SqlConnection(connectionString))
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
                                Producto producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["id"]);
                                producto.Descripciones = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVneta"]);
                                listprodcuto.Add(producto);



                            }
                        }
                    }
                    connection.Close();
                }

            }
}
