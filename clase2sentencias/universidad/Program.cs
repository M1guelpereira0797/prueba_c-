// See https://aka.ms/new-console-template for more information

string turno;
int notas;


Console.WriteLine("BIENVENIDOS A LA UNIVERSIDAD CODER HOUSE");
Console.WriteLine("Que turnos estas cursando: ");
turno= Console.ReadLine();  

switch(turno)
{
    case "manana":
        Console.WriteLine("Manana");
        break;  
        
    case "tarde":
        Console.WriteLine("Tarde");
        break ;
    case "noche":
        Console.WriteLine("Noche");
        break;
}

Console.WriteLine("Ingrese la nota del alumno: "); 
notas = Convert.ToInt32(Console.ReadLine());

if (notas >= 0 && notas < 4)
{
    Console.WriteLine("Reprobo el curso");

}
else if (notas >= 4 && notas <= 7)
{
        Console.WriteLine("aprobo el curso");

}
else if (notas > 7 && notas <= 10)
{
        Console.WriteLine("maximos honores");

}
else
{
    Console.WriteLine("Las notas tienen un rango entre 0 y 10 ");
}
