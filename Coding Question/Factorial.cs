using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Question
{
    public class Factorial
    {
        public int CalculateFactRecursive(int input)
        {
            if(input == 1)
            {
                return 1;
            }
            return input * CalculateFactRecursive(input - 1);   
        }
        public int CalculateFactSimple(int input)
        {
            int result = 1;
            for(int i = 1;i <= input; i++)
            {
                result *= i;        
            }
            return result;  
        }
    }
}
