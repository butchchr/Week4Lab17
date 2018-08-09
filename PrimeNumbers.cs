using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lab17
{
    public class PrimeNumbersGenerator
    {
        public bool GetPrimeNumber(int numToCheck)
        {
            double ceiling = Math.Sqrt(numToCheck);
            if (numToCheck >= 2)
            {
                if (numToCheck % 2 == 0)
                {
                    return false;
                }
                else if (numToCheck == 2)
                {
                    return true;
                }
            }
            for (int i = 3; i <= ceiling; i += 2)
            {
                if (numToCheck % i == 0)
                {
                    return false;
                }
            }
           
            return true;
        }

    }
}
