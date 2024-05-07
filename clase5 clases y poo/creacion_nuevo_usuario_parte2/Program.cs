namespace creacion_nuevo_usuario_parte2
{



    public class Probarobjetos
    {
        static void Main(string[] args)
        {
            /* Producto producto = new Producto(01, "panal", "limpieza", 2.9, 0);
             if(producto.haypreciodeventa())
             {
                 Console.WriteLine("Si hay a la venta");

             }
             else
             {
                 Console.WriteLine("No hay producto a la venta");
             }*/
            Producto producto1 = new Producto(01 , null, " panales " ,  5 , 6.9 );
            

            producto1.numero = 02 ;
            producto1.descripcion = " pañales pequeños " ;
            producto1.categoria = "" ;
            producto1.preciodecompra = 5 ;
            producto1.preciodeventa = 6.9 ;

            if (producto1.haypreciodeventa())
            {
                Console.WriteLine(
                " Codigo: " + producto1.numero + " " +
                " descripcion: " + producto1.descripcion + " " +
                " precio de compra: " + producto1.preciodecompra + "" +
                " prceio de venta: " + producto1.preciodeventa + "" +
                " \nCategoria: " + producto1.categoria);
            }
            else
            {
                Console.WriteLine("El prodcuto aun no se sube");
            }
            Producto producto2 = new Producto(03, "desodorante", null, 5, 10);

            producto2.numero = 03;
            producto2.descripcion = "desodo";
            producto2.preciodecompra = 10;

            if (producto2.haypreciodeventa())
            {
                Console.WriteLine(
               "\nCodigo: " + producto2.numero + " " +
               "\ndescripcion: " + producto2.descripcion + " " +
               "\nprecio de compra: " + producto2.preciodecompra + "" +
               "\nprceio de venta: " + producto2.preciodeventa + "" +
                "\nCategoria: " + producto2.categoria);
            }
            else
            {
                Console.WriteLine("El producto2 aun no se a cargado a sistema ");
            }






            
        }
    }

}