using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimaryAlgorithm.Test
{
    class Test2
    {
        public static void Main(string[] args) {
            int[] numbers = { 1,2,3,4,5,6,7 };
            var oddNumbers = from num in numbers
                             where num % 2 != 0
                             select num;
            Console.WriteLine(oddNumbers);
            
            foreach (int i in oddNumbers) {
                Console.WriteLine(i);
            }
        }
    }
}
