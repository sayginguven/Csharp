using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class MathLibrary
    {
        public static void body() {

            int absNumber = Math.Abs(-5);
            Console.WriteLine($"absNumber is : {absNumber}");// 5

            //power of a number
            Console.WriteLine($"2 to the power of 10 is : {Math.Pow(2,10)}");// 1024

            //rounding numbers
            Console.WriteLine($"round number 123.45 {Math.Round(123.45)}");// 123
            Console.WriteLine($"round number 123.55 {Math.Round(123.55)}");// 124

            Console.WriteLine($"floor the number 999.999 {Math.Floor(999.999)}"); // 999
            Console.WriteLine($"ceiling the number 999.001 {Math.Ceiling(999.001)}"); // 1000

            Console.WriteLine($"log the number 1000 {Math.Log10(1000)}");

            Console.WriteLine($"compare 2 numbers 5 and 10 and return max {Math.Max(5,10)}");
            Console.WriteLine($"compare 2 numbers 5 and 10 and return min {Math.Min(5,10)}");

            
        }

    }
}
