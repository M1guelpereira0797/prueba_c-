
namespace ClienteABM
{
    
    public partial class Form1 : Form
    {
        List<Cliente> clienteList = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente clienteBorrar = new Cliente();
            clienteList.Remove(clienteBorrar);
            dgvDatos.

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           


        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Cliente clienteLista = new Cliente();
            clienteLista.nombre = Convert.ToString(txtNombre.Text);
            clienteLista.direccion = txtDireccion.Text;
            clienteLista.iD = int.Parse(txtID.Text);
            clienteLista.edad = int.Parse(txtEdad.Text);
            clienteList.Add(clienteLista);
            dgvDatos.AutoGenerateColumns = true;
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = clienteList;



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDireccion.Clear();
            txtEdad.Clear();
            dgvDatos.ClearSelection();
            //dgvDatos.DataSource = null;
            txtID.Clear();
            txtNombre.Clear();


        }

    }
}