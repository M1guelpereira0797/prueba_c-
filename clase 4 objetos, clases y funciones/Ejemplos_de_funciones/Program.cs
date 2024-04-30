saludar();
saludar();

void saludar()
{
    Console.WriteLine("Estoy aplicando las funciones en c#");
}


int sumar( int numero1, int numero2)
{
    return numero1 + numero2;   
}


Console.WriteLine("Ingrese el primer numero");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
int numero2 = int.Parse(Console.ReadLine());

int total = sumar(numero1, numero2);    

Console.WriteLine("La suma es {0}", total);