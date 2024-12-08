using System;
using ConsoleApp1;

class Begining 
{
//===============
  static void Main()
    {
        Console.WriteLine(@"

        ===========================================================================================================
        
        [ ??? ] - Welcome, Ladies and gentalment, to...!!!!
                   _                                     _            _             _                               
        __ __ __ | |_    ___    __ __ __  __ _   _ _   | |_   ___   | |_   ___    | |__   ___     __ _             
        \ V  V / | ' \  / _ \   \ V  V / / _` | | ' \  |  _| (_-<   |  _| / _ \   | '_ \ / -_)   / _` |
         \_/\_/  |_||_| \___/    \_/\_/  \__,_| |_||_|  \__| /__/    \__| \___/   |_.__/ \___|   \__,_|
                                                                                                            
         .oooooo..o    ooooooooooooo       .o.        ooooooooo.   
        d8P'    `Y8    8'   888   `8      .888.       `888   `Y88. 
        Y88bo.              888          .8'888.       888   .d88' 
        `'Y8888o.           888         .8' `888.      888ooo88P'  
            `'Y88b          888        .88ooo8888.     888`88b.    
        oo     .d8P         888       .8'     `888.    888  `88b.  
        8''88888P'         o888o     o88o     o8888o  o888o  o888o !!!
        
        ===========================================================================================================
        IMPORTANT NOTE -> (GRABBING YOUR NAME COMES SOON.)

        [ The Host ] -
        'Now-now settle down! I am your host today, West Woodwork! Welcome to the Starfolk productions studio's 
        'Who wants to be a STAR'!' 

        'Today we have three contestants proving to us who will be our new *STAR*!'


            ");
        
        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. 'HUH? WHAT? WHERE AM I??'");
        Console.WriteLine("2. 'YES! I seek wealth! AND THE DREAM TO BE A STAR!'");
        Console.WriteLine("3. 'Erm- what does a star mean...?'");
        Console.WriteLine("4. (Stay silent.)");

        Console.Write("\nChoose your response (enter the number): ");


        string Decision_of_the_Player = Console.ReadLine();

        part2 Part2 = new part2();
        part3 Part3 = new part3();
        BridgeP2P3 P2P3 = new BridgeP2P3();

        switch (Decision_of_the_Player) 
        {
            case "1": //'HUH? WHAT? WHERE AM I??'
                Console.WriteLine(@"
            [ The Host ] - 'Like I said! The Starfolk productions studio's 'Who wants to be a STAR'!' '");
                Part2.Branch_WhereAmI();
                break;

            case "2": //'YES! I seek wealth! AND THE DREAM TO BE A STAR!'
                Console.WriteLine(@"
            [ The Host ] - 'Well contestant- erm! To get to that you'll have to beat your those 'friends' beside you then!'");
                P2P3.HUH();
                break; 

            case "3": //'Erm- what does a star mean...?'
                Console.WriteLine(@"
            [ The Host ] - '(psst It means you win.)'
            He gives you a worrisome smile.");
                P2P3.HUH();
                break;

            case "4": //(Stay silent.)
                Console.WriteLine(@"
            [ The Host ] - '...Uh-...'");
                P2P3.HUH();
                break;

            default: //retry
                Console.WriteLine(@"
            [ The Host ] - '(Pstt-! I cannot understand you mate.)' he takes a deep sigh 
            'Speak clearly for the cameras to understand, okay!'");
                break;
        }
    }


//------------------------------------------------

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
                Part3.Introduce_yourself();
                break;

            case "2":; //go back
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