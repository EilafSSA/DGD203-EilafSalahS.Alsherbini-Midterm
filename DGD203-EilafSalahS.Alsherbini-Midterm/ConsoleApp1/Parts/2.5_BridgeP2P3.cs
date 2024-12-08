using System.Collections;

namespace ConsoleApp1
{
    public class BridgeP2P3
    { 
        part3 Part3 = new part3();

   public void HUH()
    {

        //illusion of choice OOooOOoo!
        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. '-What?'");
        Console.WriteLine("2. '-Huh?");
        Console.WriteLine("3. '(stay silent)");

        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "1" or "2" or "3":;
                Console.WriteLine("");
                Part3.Introduce_yourself();
                break;

            default: //it doesn't really matter, its a break in between... but its still imporant!
                Console.WriteLine(" [ YOU ] - ( It's like if nothing happened... ) ");
                HUH();
                break;
        }
    }
    }
}