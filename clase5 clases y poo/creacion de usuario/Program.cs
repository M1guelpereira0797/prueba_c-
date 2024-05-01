class Crear_usuario
{
    static void Main(string[] args)
    {
        int preciocodigo(string codigo)
        {
            int precio = 0;
            switch (codigo)
            {
                case "DES":
                    precio = 200;
                    break;
                case "JP":
                    precio = 300;
                    break;
                case "DET":
                    precio = 250;
                    break;
                default:
                    precio = 0;
                    break;
            }
            return precio;
        }
        void ventas()
        {
            string codigo = "";
            int cantidad;
            int monto_pagar = 0;
            string confirmacion = "";
            Console.WriteLine("Bienvenido a la tiendita de gaby");
            Console.WriteLine("Producto => CODIGO => Precio");
            Console.WriteLine(" DESODORANTE  => DES => 200\n" +
                              " JABON EN POLVO => JP => 300\n" +
                              " DETERGENTE => DET => 250\n");
            Console.WriteLine("AGREGAR FIN PARA TERMINAR LA COMPRA");
            while (codigo != "FIN")
            {
                Console.WriteLine("INGRESE EL CODIGO QUE DESEA COMPRAR");
                codigo = Console.ReadLine().ToUpper();
                if (codigo == "FIN")
                {
                    break;
                }
                int precio = preciocodigo(codigo);
                Console.WriteLine("INGRESE LA CANTIDAD QUE DESEA COMPRAR");
                cantidad = int.Parse((Console.ReadLine()));

                monto_pagar += cantidad * precio;

            }
            Console.WriteLine("Su monto a pagar es de {0}", monto_pagar);
            Console.WriteLine("Desea realizar la compra: SI / NO");
            confirmacion = Console.ReadLine().ToUpper();
            if (confirmacion == "SI")
            {
                Console.WriteLine("GRACIAS POR SU COMPRA");
            }
            else
            {
                Console.WriteLine("Gracias por su tiempo");
            }

        }
    }
}
    ventas();