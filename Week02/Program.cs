using System;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables and do things with them!
            Console.WriteLine("hello WOrld");
            string myName = "Arya";
            int myAge = 32;
            string favColor = "purple";
            string myHobby = "soccer"; 
            bool isOldEnoughToDrive = false;
            double myHeight = 5.16; 
            char firstInitial = 'A'; 

            Console.WriteLine("My name is " + myName);
           //Console.Writeline("My age is {0}", myAge);
            Console.WriteLine("My age is " + myAge);
            Console.WriteLine("My favorite color is " + favColor);
            Console.WriteLine("My hobby is " + myHobby);
            Console.WriteLine(" I am old enough to drive " + isOldEnoughToDrive);
            Console.WriteLine("My height is " + myHeight);
            Console.WriteLine("My first initial is " + firstInitial);

        }
    }
}
