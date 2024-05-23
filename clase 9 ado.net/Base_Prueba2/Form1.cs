using System.Data.SqlClient;
namespace WindowsFormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=Base_Prueba2; Trusted_Connection=True";
            string query = "SELECT * FOM Id, Descripciones, Costa, PrecioVenta from Producto";
            List<Producto> listprodcuto = new List<Producto>();
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
            dgvLista.DataSource = listprodcuto;
            dgvLista.AutoGenerateColumns = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
       