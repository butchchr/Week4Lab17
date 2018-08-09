using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Lab17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrimeNumbersGenerator primeNumbers = new PrimeNumbersGenerator();
            Validator validator = new Validator();
            bool Reset = true;
            do
            {
                Console.WriteLine("Please enter an int, then I will tell you what that prime number is from 1 (example the 5th prime number is 11)");
                int primeCount = validator.IsValid(Console.ReadLine());

                List<int> primes = new List<int>();
                int number = 1;
                do
                {
                    if (primeNumbers.GetPrimeNumber(number))
                    {
                        primes.Add(number);
                    }

                    number++;
                } while (primes.Count < primeCount);
                Console.WriteLine(primes.Last());
                Console.WriteLine("Want to try again?");
                var Repeat = Console.ReadLine().ToLower();
                if (Repeat == "y"|| Repeat == "yes")
                {
                    Reset = true;
                }
                else
                {
                    Reset = false;
                }
                
            } while (Reset == true);
        }
    }
}
