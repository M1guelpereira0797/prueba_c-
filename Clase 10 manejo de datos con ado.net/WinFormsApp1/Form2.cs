using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp1.Database;
using WinFormsApp1.Models;


namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.idUsuario;
            if (idUsuario > 0)
            { 
                GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();
                Usuario _txtUsuario = gestorBaseDeDatos.GetUserById(idUsuario);
                txtNombre.Text = _txtUsuario.NombreUsuario;
                txtApellido.Text = _txtUsuario.Apellido;
                txtUsuario.Text = _txtUsuario.NombreUsuario;
                txtPassword.Text = _txtUsuario.Password;
                txtEmail.Text = _txtUsuario.Email;
                txtID.Text = _txtUsuario.Id.ToString();    

            }

            else
            {
               limpiar();
            }
        }

        private void btnElimiar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();
            gestorBaseDeDatos.DeleteUser(int.Parse(id));
            MessageBox.Show("El Usuario se elimino ");
            Program.form1.idUsuario = 0;
            this.Close();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre1 = txtNombre.Text;
            string apellido2 = txtApellido.Text;
            string usuario =txtUsuario.Text;
            string pass = txtPassword.Text;
            string mail = txtEmail.Text;
            int idUsuario = Program.form1.idUsuario;

            Usuario newUser = new Usuario(nombre1, apellido2, usuario, pass, mail );
            GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();

            if (idUsuario < 0 )
            {
                gestorBaseDeDatos.UpdateUser(idUsuario, newUser);
                MessageBox.Show("Se actualizo el usuario");
            }
            else
            {
                gestorBaseDeDatos.CreateUser(newUser);
                MessageBox.Show("Se creo nuevo el usuario");
            }
            limpiar();
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();

        }
    }
}
