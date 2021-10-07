using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{

    
    class ClassA
    {
        public bool compare(string a, string b)
        {
            if (a.Length == b.Length)
            {
                return true;
            }
            return false;
        }

        public bool compare(int [] a, int [] b)
        {
            if (a.Length == b.Length)
            {
                return true;
            }
            return false;
        }
    }
}
