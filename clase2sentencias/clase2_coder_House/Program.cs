// See https://aka.ms/new-console-template for more information
int cantidadvendidos;
int cantidaddeposito= 1000;
int stock;

Console.WriteLine("Ingrese la cantidad de productos vendidos: ");
cantidadvendidos = Convert.ToInt32(Console.ReadLine());

stock = cantidaddeposito - cantidadvendidos;

Console.WriteLine("Producto sobrante en stock " + stock);

if (stock == 0)
{

    Console.WriteLine("Reponer stock de dicho producto");
    // cantidaddeposito += 10;
    Console.WriteLine("Porductos cargados al almacen");

}
else
{

    if (stock <= 5)
    {
        Console.WriteLine("Estan quedando stock minimo de dicho producto, para que por favor estar pendiente y reponer ");
        cantidaddeposito += 5;
        Console.WriteLine("Productos cargados en el deposito");
        Console.WriteLine("Informar a producto a venta {0}", stock);
    }
    else
    {
        Console.WriteLine("Productos sin vender {0}", stock);
    }
}