using System;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        { 
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isTrue)
        {
            var sum = a + b;
            var ones = 1 | -1;

            if (isTrue == true && sum == ones)
            {
                return $"{sum} dollar";
            }
            else if (isTrue == true && sum > ones | sum < ones)
            {
                 return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
               
        static void Main(string[] args)
        {
            var addInt = Add(1, 2);
            var addDecimal = Add(0.69m, 3.51m);
            var addString = Add(34, 35, true);

            Console.WriteLine($"Add Integer answer: {addInt}. | Add Decimal answer: {addDecimal}. | Add String answer: {addString}.");
        }
    }
}
