// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string menu = (" 1. Por 5.990 te llevas 100gb.\n" +
              " 2. Por 9.990 te llevas 200gb.\n" +
              " 3. Por 14.990 te llevas 300gb.\n" +
              " 4. Por 19.990 te llevas 400gb.\n");
Console.WriteLine("Que linea telefonica quieres escoger:\n " +
                   "wom\n" +
                   "entel\n" +
                   "movistar\n");
string telefonica = Console.ReadLine();

switch (telefonica)
{

    case "entel":
        Console.WriteLine("Gracias por preferir a entel");
        break;
    case "movistar":
        Console.WriteLine("gracias por preferir a movistar");
        break;
    case "wom":
        Console.WriteLine("gracias por preferir a wom");
        Console.WriteLine("Desea agregar un plan: si / no");
        string plan = Console.ReadLine();
        if (plan == "si")
        {
            Console.WriteLine("Su plan es de 10.000 pesos, desea contratar el plan? ");
            string contratar = Console.ReadLine();
            if (contratar == "si")
            {
                Console.WriteLine("Su plan ha si contratdo");
            }
            else if (contratar == "no")
            {
                Console.WriteLine("Desea contratar otro plan");
                string otroplan= Console.ReadLine();
                if (otroplan == "si")
                {
                    Console.WriteLine(menu);
                    Console.WriteLine("Que plan desea adquirir?: ");
                    menu = Console.ReadLine();
                    
                    if (menu == "1" || menu == "2" || menu == "3" || menu == "4")
                    {
                        Console.WriteLine("Su compra a sido finalizada muchas gracias");
                    }
                    
                    
                }
                else if (menu == "no")
                {
                    Console.WriteLine("Muchas gracias, pero su compra no a podido ser exitosa");    
                }
             }
         
            
        }
        else if (plan == "no")
        {
            Console.WriteLine("Gracias por su tiempo, agradecemos su preferencia");
        }
        break;
       
}
        
