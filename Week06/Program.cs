using System;

namespace Week06
{
    class Program
    {
        static void Main(string[] args)
        {  
            userInput = Convert.ToInt32(Console.ReadLine()); 
            even(userInput);
            Console.WriteLine("Pick a number");
        }

         public static void even(int numberTwo )
            {
                int x = 0; 
            if ( numberTwo  % 2 == 0 ){
              Console.WriteLine("even");
            }
           
            }
        }
    }
}
