
namespace ConsoleApp1
{

    public class part4
    {
    
        public void YourName()
        {
            Console.WriteLine(@"
                                          l yqgmXx
                                           Y  7t
                                          x8  oi
                                        i      re
                                        z       e
                                       z  l  ____m
                                       7zpj 8 fs21
                                          i k
                                          n w
                                          gSr
                                          hAAAAAAAAAAAvmhXXRVknb
                                          c                    h
                                          b tsxyzAAA          9x
                                          or1   WUPb    zroqr6mnz
                                          jcA   QCAA          ow
                                          wrAA IrAAA           rs
                                          up     cAu  zce5dh2 uq
                                          xq     hJA           u
                                          fAAxrni71X   Ya0ez   6i
                                          a                    e
                                          5 OHd             wm 9
                                          V  qlllkqry          8w
                                          3PHMgswp5DE50ptrxtzz
                                  9Ov                         bwwQ
                             wplff  g                         su 9qck
                           w9S o h b                           j wn2df
                           h 7 t f 4  5s                   6 p o  ohq 9
                           nx------d  hmx                  zy5 c  ----uZy
                           tou        0                    k u      uv
            [IMG ID: a man is pointing at a document with a picture of YOU.]
            ========================================
            A MEMORY - 72 HOURS AGO.
            [ ??? ] - 'Could you write your name?'
            A suited man points towards a paper with your face on it.
            * You can write your name now *
            ");
            COLLECTION();
        }

        public void COLLECTION()
        {
            Console.WriteLine(" [ You ] - ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine(@"
        [ ??? ] - 'A proper name. Will you?'
        (He gives you a pitiful smile.)
        ");
                COLLECTION();
            }
            else
            {
                Console.WriteLine(@"
        Your name is " + name + " ... That's cool... Look, you should probably come back now, to the show or whatever that is.");

                Console.WriteLine(" [ You ] - ");
                Console.WriteLine("1. (Open your eyes harder)");

                string Decision_of_the_Player = Console.ReadLine();

                switch (Decision_of_the_Player)
                {
                    case "1":
                        Console.WriteLine(" ");
                        Console.WriteLine(@"
    [ HOST ] - 'And a round of applause to Jeffy! Ayyy!'
    (The Host looks back towards your direction)
    'Oh! and! Our contestant is back, Everyone! What should we call you, mysterio? Hmmm?'
    ");
                        Sayingyourname();
                        break;
                }
            }
        }

        
        public void Sayingyourname()
        {
            Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. (Say your name)");

        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "1": //'I mean like- *where* am I...'
                Console.WriteLine("[ The Host ] - 'Ah! thats a marvelous name! Isn't it? (the faceless audience claps in response)'");
                Console.WriteLine(" ");
                Console.WriteLine("[ The Host ] - 'TIME FOR ACTUAL SEGMENT!'");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                RHYMING_AWAY_START();
                break;
            default: //retry
                Console.WriteLine("[ The Host ] - 'I couldn't hear you mate? What was your name again?'");
                Sayingyourname();
                break;
        }
        }
    private int score_for_player = 0; 
      public void RHYMING_AWAY_START()
    {
        Console.WriteLine(@"

        [OUR NEW GAME IS.......]
         ___   _  _  __   __  __  __   ___   _  _    ___       _    __      __    _    __   __  _ 
        | _ \ | || | \ \ / / |  \/  | |_ _| | \| |  / __|     /_\   \ \    / /   /_\   \ \ / / | |
        |   / | __ |  \ V /  | |\/| |  | |  | .` | | (_ |    / _ \   \ \/\/ /   / _ \   \ V /  |_|
        |_|_\ |_||_|   |_|   |_|  |_| |___| |_|\_|  \___|   /_/ \_\   \_/\_/   /_/ \_\   |_|   (_)
        *rhyming away!

        [ HOST ] - 'YOUR JOB IS TO QUICKLY PUT THE CORRECT RYHME TO THE WORD AND YOULL GET OFF WITH BEING THE STAR OF THE DAY!'

        [ HOST ] - 'YOU'LL NEED 3 POINTS TO AT LEAST WIN!'

        [ HOST ] - 'IS EVERYONE READY?'      


        ");

        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. 'I'm Ready!'");
        Console.WriteLine("1. 'I'm actually not Ready!'");


        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "1":;
                Console.WriteLine(" ");
                Console.WriteLine(" [ HOST ] - GREAT! LETS GET STARTED!");
                Console.WriteLine(" ");
                QUESTION_ONE();
                break;

            case "2":;
                Console.WriteLine(" 'REEADY' 'READY!'");
                Console.WriteLine(" Your voice is drowned out by the other contestants excitment.");
                Console.WriteLine(" ");
                Console.WriteLine(" [ HOST ] - GREAT! LETS GET STARTED!");
                Console.WriteLine(" ");
                QUESTION_ONE();
                break;

            default:
                RHYMING_AWAY_START();
                break;    
        }
    }
    public void QUESTION_ONE()
    {
       Console.WriteLine(@"

        [QUESTION ONE!]
        [ HOST ] - WHAT RHYMES WITH...
   ___     _     _____ 
  / __|   /_\   |_   _|
 | (__   / _ \    | |  
  \___| /_/ \_\   |_|                     
*cat!

        ");

        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. 'Hat!'");
        Console.WriteLine("2. 'Mouse!'");
        Console.WriteLine("3. 'String!'");
        Console.WriteLine("4. 'Fish!'");


        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "1":;
                score_for_player += 1;
                Console.WriteLine("");
                Console.WriteLine(" [ HOST ] - 'THERE YOU DO! a point for you!'");
                Console.WriteLine("");
                QUESTION_TWO();
                break;

            case "2" or "3" or "4":;
                Console.WriteLine("");
                Console.WriteLine(" [ HOST ] - 'AWW, THATS INCORRECT! Maybe the next question will be better for you!'");
                Console.WriteLine("");
                QUESTION_TWO();
                break;

            default:
                QUESTION_ONE();
                break;    
        } 

    }
public void QUESTION_TWO()
    {
       Console.WriteLine(@"

        [QUESTION ONE!]
        [ HOST ] - WHAT RHYMES WITH...
  ___    ___   ____  ____ __   __
 |   \  |_ _| |_  / |_  / \ \ / /
 | |) |  | |   / /   / /   \ V / 
 |___/  |___| /___| /___|   |_|                                                        
*dizzy!

        ");

        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. 'Crazy!'");
        Console.WriteLine("2. 'Fizzy!'");
        Console.WriteLine("3. 'Wizard!'");
        Console.WriteLine("4. 'Pop!'");


        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "2":;
                score_for_player += 1;
                Console.WriteLine("");
                Console.WriteLine(" [ HOST ] - 'Atta boy! Look at how fast they are!'");
                Console.WriteLine("");
                QUESTION_THREE();
                break;

            case "1" or "3" or "4":;
                Console.WriteLine("");
                Console.WriteLine(" [ HOST ] - 'MUST OF BEEN THE NERVES EH? BUT NO, YOU'RE INCORRECT.'");
                Console.WriteLine("");
                QUESTION_THREE();
                break;

            default:
                QUESTION_TWO();
                break;    
        } 

    }
    public void QUESTION_THREE()
    {
       Console.WriteLine(@"

        [QUESTION ONE!]
        [ HOST ] - WHAT RHYMES WITH...
  ___    ___    ___   _   _   _        _     ___ 
 | _ \  / _ \  | _ \ | | | | | |      /_\   | _ \
 |  _/ | (_) | |  _/ | |_| | | |__   / _ \  |   /
 |_|    \___/  |_|    \___/  |____| /_/ \_\ |_|_\                                             
*popular!

        ");

        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. 'Famous!'");
        Console.WriteLine("2. 'Star!'");
        Console.WriteLine("3. 'dinosaur!'");
        Console.WriteLine("4. 'binocular!'");


        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "4":;
                score_for_player += 1;
                Console.WriteLine("");
                Console.WriteLine(" [ HOST ] - 'haha! You're doing great!'");
                Console.WriteLine("");
                QUESTION_FOUR();
                break;

            case "1" or "2" or "3":;
                Console.WriteLine("");
                Console.WriteLine(" [ HOST ] -  ( The audience Awes.) 'Awww Nooo, but this one was a bit tricky, yes. I don't fault you'");
                Console.WriteLine("");
                QUESTION_FOUR();
                break;

            default:
                QUESTION_TWO();
                break;    
        } 

    }
    public void QUESTION_FOUR()
    {
       Console.WriteLine(@"

        [QUESTION ONE!]
        [ HOST ] - WHAT RHYMES WITH...
  ___     _     ___   _  _ 
 | _ \   /_\   |_ _| | \| |
 |  _/  / _ \   | |  | .` |
 |_|   /_/ \_\ |___| |_|\_|                                    
*pain!

        ");

        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. 'Rain!'");
        Console.WriteLine("2. 'Suffering!'");
        Console.WriteLine("3. 'Owie!'");
        Console.WriteLine("4. 'Spikes!'");


        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "1":;
                score_for_player += 1;
                Console.WriteLine("");
                Console.WriteLine(" [ HOST ] - 'And that's that! You got the final point!'");
                Console.WriteLine("");
                FINALLE();
                break;

            case "2" or "3" or "4":;
                Console.WriteLine("");
                Console.WriteLine(" [ HOST ] - 'Ahh, anndd thats INCORRECT!' (the audience laughs)");
                Console.WriteLine("");
                FINALLE();
                break;

            default:
                QUESTION_FOUR();
                break;    
        } 

    }
    public void FINALLE()
    {
       Console.WriteLine(@"


   _____   _______    ____    _____  
  / ____| |__   __|  / __ \  |  __ \ 
 | (___      | |    | |  | | | |__) |
  \___ \     | |    | |  | | |  ___/ 
  ____) |    | |    | |__| | | |     
 |_____/     |_|     \____/  |_|     !!
*stop!!

[ HOST ] - 'THAT'S IT FOR TONIGHT EVERYONE!' (Audience Awes) 'BUT DON'T WORRY! LET'S END TONIGHT WITH THE TALLY!'

[ HOST ] - 'AND WHO OF THESE THREE WILL BE A 'STAR!!!!'
                        



        ");

        if (score_for_player >= 3)
          Console.WriteLine(@"

=====================================================================================================
   ____     U  ___ u   _   _        ____      ____         _        _____     ____       _    
U /'___|     \/'_ \/  | \ |'|    U /'___|u U |  _'\ u  U  /'\  u   |_ ' _|   / __'| u  U|'|u  
\| | u       | | | | <|  \| |>   \| |  _ /  \| |_) |/   \/ _ \/      | |    <\___ \/   \| |/  
 | |/__  .-,_| |_| | U| |\  |u    | |_| |    |  _ <     / ___ \     /| |\    u___) |    |_|   
  \____|  \_)-\___/   |_| \_|      \____|    |_| \_\   /_/   \_\   u |_|U    |____/>>   (_)   
 _// \\        \\     ||   \\,-.   _)(|_     //   \\_   \\    >>   _// \\_    )(  (__)  |||_  
(__)(__)      (__)    (_')  (_/   (__)__)   (__)  (__) (__)  (__) (__) (__)  (__)      (__)_) 
*Congrats!

YOU DID IT! YOU ARE NOW THE

        .oooooo..o    ooooooooooooo       .o.        ooooooooo.   
        d8P'    `Y8    8'   888   `8      .888.       `888   `Y88. 
        Y88bo.              888          .8'888.       888   .d88' 
        `'Y8888o.           888         .8' `888.      888ooo88P'  
            `'Y88b          888        .88ooo8888.     888`88b.    
        oo     .d8P         888       .8'     `888.    888  `88b.  
        8''88888P'         o888o     o88o     o8888o  o888o  o888o !!!
        
                                                                 OF THE DAY!

            NOW BASK IN YOUR 2 MINUTES OF FAME AND GET OUTTA HERE. BYEBYE!

=====================================================================================================");


if (score_for_player <= 2)
          Console.WriteLine(@" 
  __   __    U  ___ u    _   _         _         U  ___ u   ____      ______
  \ \ / /     \/'_ \/ U |'|u| |       |'|         \/'_ \/  / __'| u   |_ ' _|  
   \ V /      | | | |  \| |\| |     U | | u       | | | | <\___ \/      | |    
  U_|'|_u .-,_| |_| |   | |_| |      \| |/__  .-,_| |_| |  u___) |     /| |\   
    |_|    \_)-\___/   <<\___/        |_____|  \_)-\___/   |____/>>   u |_|U   
.-,//|(_        \\    (__) )(         //  \\        \\      )(  (__)  _// \\_  
 \_) (__)      (__)       (__)       (_')('_)      (__)    (__)      (__) (__) 
 *you Lost...
 
 MAYBE NEXT TIME FELLA! EVERYONE GETS THE CHANCE TO BE A STAR, IT DOESN'T HAVE TO BE IN THIS BUILDING.

 BE YOUR OWN STAR.
 ");
    }
    }
}


