/*Console.WriteLine("Bienvenido a la tiendita de gaby");

// desodorante=> precio 200=> codigo DES
// JABON EN POLVO => PRECIO 300 => CODIGO DE BUSQUEDA JP
// DETERGENTE => PRECIO 250 => CODIGO DE BUSQUEDA DET

string codigo;


 
Console.WriteLine("Producto => CODIGO");
Console.WriteLine(" DESODORANTE  => DES \n" +
                  " JABON EN POLVO => JP \n" +
                  " DETERGENTE => DET \n");
Console.WriteLine("Ingrese el codigo del producto que desea buscar: ");
codigo = Console.ReadLine();

switch(codigo)
{
    case "des":
        Console.WriteLine("El precio del desodorante es de 200 pesos, agregar :  ");
        string continua = Console.ReadLine();
        if (continua == "si")
        {
            Console.WriteLine("cuantos desea: ");
            int cantidad = int.Parse(Console.ReadLine());
            int suma_precio = 200 * cantidad;
            Console.WriteLine("La cantidad a pagar es: {0}", suma_precio);
        }
        if (continua == "fin")
        {
            
        }
        break;
    case "jp":
        Console.WriteLine("El precio del desodorante es de 300 pesos");
        break;
    case "det":
        Console.WriteLine("El precio del desodorante es de 250 pesos");
        break;
    case "fin":
        Console.WriteLine("");
        break;


}
Console.ReadKey();*/
int preciocodigo(string codigo)
{
    int precio = 0;
    switch(codigo)
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
    string codigo="";
    int cantidad;
    int monto_pagar=0;
    string confirmacion = ""; 
    Console.WriteLine("Bienvenido a la tiendita de gaby"); 
    Console.WriteLine("Producto => CODIGO => Precio");
    Console.WriteLine(" DESODORANTE  => DES => 200\n" +
                      " JABON EN POLVO => JP => 300\n" +
                      " DETERGENTE => DET => 250\n");
    Console.WriteLine("AGREGAR FIN PARA TERMINAR LA COMPRA");
    while(codigo != "FIN")
    {
        Console.WriteLine("INGRESE EL CODIGO QUE DESEA COMPRAR");
        codigo= Console.ReadLine().ToUpper();
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
ventas();