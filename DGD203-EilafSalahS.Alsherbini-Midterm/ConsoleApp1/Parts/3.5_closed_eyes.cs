namespace ConsoleApp1
{
    public class part3point5
    {
    part4 Part4 = new part4();
    public void Closed_eyes()
    {
        Console.WriteLine(@"
        The lights flicker and you feel a tense anxiety looming.
        
        (You try to look for your name in your mind.)

        Flick. Flick. You feel like time is clicking when the Host says aloud
        
        [ Host ] - ' Alright... Well! Let's go to the miss right beside them then! Whats your na-'

        ");
        //illusion of choice OOooOOoo!
        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. (Close your eyes harder)");

        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "1":;
                Console.WriteLine(" ");
                Console.WriteLine(" [ YOU ] - ( You sink deeper.) ");
                Part4.YourName();
                break;

            default: //it doesn't really matter, its a break in between... but to keep order in this game! it is 
                Closed_eyes();
                break;    
        }
    }
    }
}