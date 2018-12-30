using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInVS
{
    public class Feature1
    {
        public static int Factorial(int factorial)
        {
            if (factorial == 1)
                return 1;
            else
                return factorial * Factorial(factorial - 1);
             
        }
    }
}
