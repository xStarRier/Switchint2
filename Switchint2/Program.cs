// See https://aka.ms/new-console-template for more information
//Ta utgangspunkt fra oppgave 1, men istedenfor å bruke en int med en fastsatt value, bruker du Console.ReadLine() for at man kan skrive inn et tall i konsollen. 
//Hvis man ikke får inn et tall, skal switch-en kjøre programmet på nytt. 


Run();
void Run()
{
    ;
    Console.WriteLine("What day is it?");
    var randomNum = Console.ReadLine();

    switch (randomNum)

    {

        case "1":
            Console.WriteLine("Monday");
            break;
        case "2":
            Console.WriteLine("Tuesday");
            break;
        case "3":
            Console.WriteLine("Wednesday");
            break;
        case "4":
            Console.WriteLine("Thursday");
            break;
        case "5":
            Console.WriteLine("Friday");
            break;
        case "6":
            Console.WriteLine("Saturday");
            break;
        case "7":
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("What day is it?");
            break;
    }


}
    
            
