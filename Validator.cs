using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lab17
{
    class Validator
    {
        public int IsValid(string primeCount)
        {
            
            if (!string.IsNullOrWhiteSpace(primeCount))
            {
                int num;
                int.TryParse(primeCount, out num);
                if (num > 0)
                {
                    return num;
                }
                Console.WriteLine("Try again");
            }
            return 0;
        }
    }
}
