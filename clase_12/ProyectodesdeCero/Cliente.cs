using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectodesdeCero.Database;
using ProyectodesdeCero.Models;
using System.Data.SqlClient;

namespace ProyectodesdeCero
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.CargaClientes();
            Program.form1.Show();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            int idCliente = Program.form1.id;
            if (idCliente > 0)
            {
                var db = new DatabaseContext();
                Usuario _txtCliente = db.Usuario.Find(idCliente);
                txtNombre.Text = _txtCliente.Nombre;
                txtApellido.Text = _txtCliente.Apellido;
                txtDomicilio.Text = _txtCliente.Domicilio;
                txtTelefono.Text = _txtCliente.Telefono;
                txtId.Text = _txtCliente.id.ToString();

            }
            else
            {
                limpiar();
            }

        }

        private void limpiar()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDomicilio.Text = null;
            txtTelefono.Text = null;
            txtId.Text = null;
        }

        private void Guardar1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            //string idCliente = txtId.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            int idUsuario = Program.form1.id;


            DatabaseContext db = new DatabaseContext();



            if (idUsuario > 0)
            {
                Usuario usuarioEdit = db.Usuario.Find(idUsuario);
                usuarioEdit.Nombre = nombre;
                usuarioEdit.Apellido = apellido;
                usuarioEdit.Domicilio = domicilio;
                usuarioEdit.Telefono = telefono;

                MessageBox.Show("Se modifico el Cliente");

            }
            else
            {
                Usuario usuarioNew     = new Usuario();
                usuarioNew.Nombre = nombre;
                usuarioNew.Apellido = apellido;
                usuarioNew.Domicilio = domicilio;
                usuarioNew.Telefono = telefono;

                db.Usuario.Add(usuarionew);
                MessageBox.Show("Se creo el nuevo Cliente");
            }
            db.SaveChanges();
            limpiar();
            this.Close();
            Program.form1.id = 0;
            Program.form1.CargaClientes();
            Program.form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;

            var db = new DatabaseContext();

            Usuario usuario = db.Usuario.Find(int.Parse(id));
            db.Usuario.Remove(usuario);
            db.SaveChanges();
            MessageBox.Show("Se borro el Cliente");
            limpiar();
            Program.form1.id = 0;
            this.Close();
            Program.form1.CargaClientes();
            Program.form1.Show();


        }
    }
}






