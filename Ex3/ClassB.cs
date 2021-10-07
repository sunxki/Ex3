using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class ClassB : ClassA,Interface1

    //Create an interface.

    {
        public void printInterfase()
        {
            Console.WriteLine("Hello Interface");
        }

        public void orderAsc(string [] matrix)
        {
            Console.WriteLine("--ASC--");
            matrix = matrix.OrderBy(d => d).ToArray();
            Array.ForEach(matrix, x => Console.WriteLine(x));
        }

        public void orderDesc(string[] matrix)
        {
            Console.WriteLine("--DESC--");
            matrix = matrix.OrderByDescending(d => d).ToArray();
            Array.ForEach(matrix, x => Console.WriteLine(x));
        }
        public void removeWhitespace(string[] matrix)
        {
            Console.WriteLine("------");
            for (int i = 0; i <= matrix.Length - 1; i++)
            {
                if (matrix[i] == " ")
                {
                    matrix = matrix.Where((source, index) => index != i).ToArray();
                    Array.ForEach(matrix, x => Console.WriteLine(x));
                }
            }
        }
        public void removeDuplicate(int[] matrix)
        {
            matrix = matrix.Distinct().ToArray();
            Array.ForEach(matrix, x => Console.WriteLine(x));

        }
    }
}
