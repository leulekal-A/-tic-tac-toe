using System;
namespace assignment1 
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Welcome to the tictactoe game,please enter the inputs by order to test the program");
        
         

        


            char a1, a2, a3, a4, a5, a6, a7, a8, a9, a = 'x';
            a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = ' ';
            int i = 0;
            
 
            do
            {

            Console.WriteLine($" {a1} | {a2} | {a3}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {a4} | {a5} | {a6}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {a7} | {a8} | {a9}");

                if (++i > 9)
                    break;

                bool ok = false;
                do
                {
                    Console.WriteLine("first user ");
                    switch (Console.ReadLine())
                    {
                    case "1": 

                            if (a1 == ' ')
                         { 
                             a1 = a; ok = true; 
                         }; 
                                 break;


                        case "2":

                         if (a2 == ' ')
                          { 
                              a2 = a; ok = true; 
                          };
                                   break;


                        case "3":

                         if (a3 == ' ')
                          { 
                              a3 = a; ok = true;
                          }; 
                                    break;
                        case "4": 

                        if (a4 == ' ') 
                        {
                         a4 = a; ok = true; 
                        }; 
                                    break;
                        case "5": 
                    
                        if (a5 == ' ')
                         { 
                             a5 = a; ok = true; 
                         }; 
                             break;
                        case "6":

                         if (a6 == ' ')
                          { 
                              a6 = a; ok = true; 
                          };
                           break;
                        case "7":

                         if (a7 == ' ')
                          { 
                              a7 = a; ok = true;
                          };
                           break;
                        case "8": 
                        if (a8 == ' ') 
                        {
                             a8 = a; ok = true;
                        }; 
                        break;

                        case "9":

                         if (a9 == ' ')
                          { 
                              a9 = a; ok = true;
                          }; 
                          break;

                    }
                    if (!ok) { Console.WriteLine("place correctly and write the correct input please"); }
                } 
                while (!ok);
                          if (a == 'x')
                           a = 'o';
                else
                         a = 'x';

            }
                   
                   while (true);

            Console.WriteLine("Game is over");
            
            
             Console.ReadKey();
        }
    }
}
     
       