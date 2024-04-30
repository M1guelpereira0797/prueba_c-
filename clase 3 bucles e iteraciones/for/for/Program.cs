// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*int i;
int cantidad_notas;
double promedio;
double nota;
double suma_notas=0;
Console.WriteLine("Ingrese la cantidad de notas: ");
cantidad_notas = int.Parse(Console.ReadLine());


for(i = 0; i < cantidad_notas; i++)

{
    Console.WriteLine("Ingrese la nota: ");
    nota = double.Parse(Console.ReadLine());
    suma_notas += nota;
    

}

promedio = suma_notas / cantidad_notas;


Console.WriteLine("La notas es de: {0} ", promedio);
Console.WriteLine("Ingrese UN numero  para clasificar");
Console.WriteLine("Para salir apretar el 0");
int numero = int.Parse(Console.ReadLine());

while (numero != 0)
{
    if(numero > 0 )
    {
        Console.WriteLine("El numero es positivo");

    }
    else
    {
        Console.WriteLine(" Numero negativo");
    }

    Console.WriteLine("La notas es de: {0} ", promedio);
    Console.WriteLine("Ingrese UN numero  para clasificar");
    Console.WriteLine("Para salir apretar el 0");
    numero = int.Parse(Console.ReadLine());

}
*/
int multiplosdecinco;

Console.WriteLine("Ingrese un numero: ");
multiplosdecinco = int.Parse(Console.ReadLine());
Console.WriteLine("Los multiplos de 5 son: {0} ", multiplosdecinco);
for (int i = 0; i <= multiplosdecinco; i++)
{
    if (i % 5 == 0)
    {
        Console.Write(i + ", ");
    }
}