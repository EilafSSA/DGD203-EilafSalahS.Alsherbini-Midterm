namespace ConsoleApp1
{
    public class part3
    {
    public void Introduce_yourself()
    {
        
    part3point5 Part3point5 = new part3point5();
    part4 Part4 = new part4();        

        Console.WriteLine(@"  

============================================================================================================================
  ___   _  _   _____   ___    ___    ___    _   _    ___   ___    __   __   ___    _   _   ___   ___   ___   _      ___   _ 
 |_ _| | \| | |_   _| | _ \  / _ \  |   \  | | | |  / __| | __|   \ \ / /  / _ \  | | | | | _ \ / __| | __| | |    | __| | |
  | |  | .` |   | |   |   / | (_) | | |) | | |_| | | (__  | _|     \ V /  | (_) | | |_| | |   / \__ \ | _|  | |__  | _|  |_|
 |___| |_|\_|   |_|   |_|_\  \___/  |___/   \___/   \___| |___|     |_|    \___/   \___/  |_|_\ |___/ |___| |____| |_|   (_)
                                                                                                                            
                                         w                                        
                        ev             mkrot          yqnno                       
                        b xyyrnnpsrptyw     tvyyzzyzuw     zvu             wt     
                      ws                                      xyvpuy   zvnnhq     
                strorrz                                                   wr           
                  rs                                       ujr            nk      
                   xy           lcf2Zw       wvy  y0     s     uu         wt      
                    nu        uf     er     v       d   u       gt         vw     
                     I        t  o  o  |    n  ^ ^  y  4  -  -  ky          uz    
                    hp        tk      u     pc     i    6      rq            t    
                   wv   YOU->   m0   4u        r  t      w04  wpw          vhmry   
                  tp             cg ay       vu   Q5     yc     8v      su        
                moymeky         ge    7     z      ay   n       m      l          
                       ey      yu     q      I     Vy   t      hm     r           
                        wn     kb      f     y     u    r      qu    p            
                         g     ib      6     w     w    i      ds    u            
                         c     lf      l    to     r   yr      cw    u            
                          bZVeifemsy     tyyy         s1z wmik8dw   wucp          
                          86urx    wmlroexy3   zm54bvkhx7yvwvrlnsvxzc             
                         uu             o  h         s             wo             
   

[IMG ID: its the contestents on tables with a burst on the back, the first one on the left is 'YOU'.]

[HOST] - 'You'll all get a chance to introduce yourselves! Lets start... With YOU first!'

( You realize you dont know your own name... )
                                                                                                ");
        Console.WriteLine(" [ You ] - ");
        Console.WriteLine("1. 'Um... I don't want to say my name...'");
        Console.WriteLine("2. (Try to remember your name.)");

        string Decision_of_the_Player = Console.ReadLine();

        switch (Decision_of_the_Player)
        {
            case "1":
                Console.WriteLine("[ The Host ] - 'Oh come on! Everyones got a name! Don't worry at all! Use your noggin!'");
                Part3point5.Closed_eyes();
                break;

            case "2": //remeber
                Console.WriteLine("[ The Host ] - 'Come on! You can catch up! can you keep up?' (He pats your shoulder lightly.)");
                Part3point5.Closed_eyes();
                break;

            default: //retry
                Console.WriteLine("[ The Host ] - 'I couldn't hear you mate? Can you say something more uhh- valid?'");
                Introduce_yourself();
                break;

        }
    }       
    }
}