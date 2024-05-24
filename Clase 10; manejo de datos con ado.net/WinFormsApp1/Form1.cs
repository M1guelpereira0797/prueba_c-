using WinFormsApp1.Database;


namespace WinFormsApp1

{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Program.form1.Hide();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GestorBaseDeDatos database = new GestorBaseDeDatos();
            dgvUsuario.AutoGenerateColumns = true;
            dgvUsuario.DataSource = database.ListaUsuarios();
        }
    }
}