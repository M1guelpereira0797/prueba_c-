using WinFormsApp1.Database;


namespace WinFormsApp1

{
    public partial class Registro : Form
    {
        
        public Registro()
        {
            InitializeComponent();
        }
        public int idUsuario;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Program.form1.Hide();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idUsuario = 0;
            GestorBaseDeDatos database = new GestorBaseDeDatos();
            dgvUsuario.AutoGenerateColumns = true;
            dgvUsuario.DataSource = database.ListaUsuarios();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 ) // verifica si se hixo click en una fila vacia
            {
                int filasSeleccionada = (int)e.RowIndex;
                idUsuario = int.Parse(dgvUsuario[0, filasSeleccionada].Value.ToString());
            }
            Form2 form2 = new Form2();
            Program.form1.Hide();
            form2.Show();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = null;
            dgvUsuario.Refresh();
            GestorBaseDeDatos database = new GestorBaseDeDatos();
            dgvUsuario.AutoGenerateColumns = true;
            dgvUsuario.DataSource = database.ListaUsuarios();

        }
    }
}