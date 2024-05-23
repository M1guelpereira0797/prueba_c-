using System.Data.SqlClient;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string connection = "Server=; Database=Base_Prueba; Trusted_Connection=True";
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba2; Trusted_Connection=True";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                connection.Open();
                
                string query= "SELECT * FROM Usuario";
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    using(SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while(dataReader.Read())
                            {
                                var dato = dataReader.GetString(1);
                                Console.WriteLine(dato);
                            }
                        }

                    }
                }
                connection.Close();
                /* //definimos el conectionstring(la puerta)
                 * string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba2; Trusted_Connection=True";
                 *  // creamos la conexion
                 * using (SqlConnection connection = new SqlConnection(connectionString))
                 * {
                 *      // creo el adaptador de datos con la query que voy a ejecutar 
                 *      SqlDataAdapter adapter = new DataAdapter("SELECT * FROM Tabla", conect);
                 *      
                 *      //abro la coneccion
                 *      connection.open();
                 *      
                 *      //recupero el resultado y lo guardo en un dataSet
                 *      Dataset resultado = new DataSet();
                 *      adapter.Fill(resultado);
                 *      
                 *      //cierro la coneccion
                 *      connecttion.Close;
                 *      
                 * 
                 * 
                 * 
                 * }
                 * 
                 * 
                 */
            }
        }
    }
}