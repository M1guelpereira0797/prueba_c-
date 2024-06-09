using ProyectodesdeCero.Models;
using ProyectodesdeCero.Database;

namespace ProyectodesdeCero
{
    public partial class Form1 : Form
    {
        public int id;
        public string datosCargados;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargaClientes();
        }
        public void CargaClientes()
        {
            comboBox1.SelectedIndex = 0;
            var db = new DatabaseContext();

            var usuario = db.Usuario
                .OrderBy(b => b.id)
                .ToList();
            dgvClienteProducto.AutoGenerateColumns = true;
            dgvClienteProducto.DataSource = usuario;
            datosCargados = "Usuario";
        }

    

      

        private void btnAgregar1_Click_1(object sender, EventArgs e)
        {
            if (datosCargados == "Productos")
            {
                ProductoForm productoForm = new ProductoForm();
                Program.form1.Hide();
                productoForm.Show();
            }
            else
            {
                Cliente clienteForm = new Cliente();
                Program.form1.Hide();
                clienteForm.Show();
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                id = int.Parse(dgvClienteProducto[0, filaSeleccionada].Value.ToString());
            }


            if (datosCargados == "Productos")
            {
                ProductoForm productoForm = new ProductoForm();
                Program.form1.Hide();
                productoForm.Show();
            }
            else
            {
                Form clienteForm = new Form();
                Program.form1.Hide();
                clienteForm.Show();
            }
        }

        

        internal void CargaProductos()
        {
            comboBox1.SelectedIndex = 1;
            var db = new DatabaseContext();

            var productos = db.Productos
                .OrderBy(b => b.Id)
                .ToList();
            dgvClienteProducto.AutoGenerateColumns = true;
            dgvClienteProducto.DataSource = productos;
            datosCargados = "Productos";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            if (selectValue == "Clientes")
            {
                CargaClientes();
            }
            else if (selectValue == "Productos")
            {
                CargaProductos();
            }
            else
            {
                CargaClientes();

            }

        }
    }
}

        