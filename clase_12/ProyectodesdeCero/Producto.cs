using System.Data.SqlClient;
using System.Windows.Forms;
using ProyectodesdeCero.Models;
using ProyectodesdeCero.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ProyectodesdeCero
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void btnVovler_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.CargaProductos();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string costo = txtPrecioCosto.Text;
            string descripcion = txtDescripcion.Text;
            string stock = txtStock.Text;
            string idUsuario = txtIdUsuario.Text;
            string precioVenta = txtPrecioVenta.Text;

            int idProducto = Program.form1.id;
            DataBaseCliente db = new DataBaseCliente();

            if (idProducto > 0)
            {
                Producto productoEdit = db.Productos.Find(idProducto);
                productoEdit.PrecioVenta = decimal.Parse(precioVenta);
                productoEdit.Descripcion = descripcion;
                productoEdit.Costo = decimal.Parse(costo);
                productoEdit.IdUsuario = int.Parse(idUsuario);
                productoEdit.Stock = int.Parse(stock);

                MessageBox.Show("Se actualizo el producto");
            }
            else
            {
                Producto newProducto = new Producto();

                newProducto.PrecioVenta = decimal.Parse(precioVenta);
                newProducto.Descripcion = descripcion;
                newProducto.Costo = Decimal.Parse(costo);
                newProducto.Stock = int.Parse(stock);
                newProducto.IdUsuario = int.Parse(idUsuario);

                db.Productos.Add(newProducto);
            }
            db.SaveChanges();
            limpiar();
            this.Close();
            Program.form1.id = 0;
            Program.form1.CargaProductos();
            Program.form1.Show();

        }
        private void limpiar()
        {

        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            var db = new DatabaseContext();

            Producto cliente = db.Producto.Find(int.Parse(id));

            db.Productos.Remove(producto);
            db.SaveChanges();
            MessageBox.Show("Se borro el Producto");
            limpiar();
            Program.form1.id = 0;
            this.Close();
            Program.form1.CargaProductos();
            Program.form1.Show();

        }
    }
}
