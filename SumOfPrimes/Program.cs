using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
      
            ulong sum = 0;
            var lim = 10000;
            var numbers = new List<uint>();
            var TempList = new List<uint>();
            for(var i = 2u; ; i++)
            {
                numbers.Add(i);
                if (numbers.Count == lim) break;
            }
            for(var i = 0; i < numbers.Count; i++)
            {
                for(var j = 2u; j < lim; j++)
                {
                    numbers.Remove(numbers[i] * j);
                }
             
            }
            
            Console.WriteLine(numbers.Max<uint>());
        }
    }
}
