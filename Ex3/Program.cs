using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] randomNumbers = { 10, 2, 3, 15, 5, 52, 8, 101 };
            string[] randomWords = { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
            int[] requestedNumbers = { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };
            
            
            ClassA obj1 = new ClassA();
            //Method that compares if the lenght of 2 strings are the same
            Console.WriteLine(obj1.compare("David", "Dario"));

            //Method that compares if the size of 2 lists are the same
            Console.WriteLine(obj1.compare(randomNumbers, randomNumbers));

            //Use functionality from (A) in a new method from (B)
            ClassB obj2 = new ClassB();
            Console.WriteLine(obj2.compare(randomNumbers, randomNumbers));

            //Method that orders by desc and asc order based on a parameter.
            obj2.orderAsc(randomWords);
            obj2.orderDesc(randomWords);

            //Method that filters the above list, not selecting white spaces (" ").

            obj2.removeWhitespace(randomWords);

            //Create a method that removes duplicate number
            obj2.removeDuplicate(requestedNumbers);
            Console.ReadLine();
        }
    }
}
