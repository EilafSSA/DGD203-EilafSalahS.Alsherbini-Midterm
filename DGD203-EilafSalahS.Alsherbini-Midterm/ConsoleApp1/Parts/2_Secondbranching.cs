using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    public class part2
    { 
        part3 Part3 = new part3();

   public void Branch_WhereAmI()
    {

        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. 'I mean like- *where* am I...'");
        Console.WriteLine("2. 'Oh right...' (go back)");

        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "1": //'I mean like- *where* am I...'
                Console.WriteLine("[ The Host ] - 'In... America? The production is starting in 5, we gotta continue on the show!'");
                        Console.WriteLine(@"

        [ HOST ] - 'WELP! TIME FOR THE NEW SEGMENT!' 
        
        ");
                Part3.Introduce_yourself();
                break;

            case "2":; //go back
            Console.WriteLine("[ The Host ] - 'In... America? The production is starting in 5, we gotta continue on the show!'");
                        Console.WriteLine(@"
                        
        [ HOST ] - 'WELP! TIME FOR THE NEW SEGMENT!' 
        
        ");
                Part3.Introduce_yourself();
                break;

            default: //retry
                Console.WriteLine("[ The Host ] - 'I couldn't hear you mate? Can you say something more... Valid?'");
                Branch_WhereAmI();
                break;
        }
    }
    }
}
        