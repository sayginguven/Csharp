using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Loops
    {
        public static void body() {

            //for loop

            //for (int i = 0; i < 10; i += 1) {
            //    Console.WriteLine($"{i+1} I wont sleep in the class again");
            //}

            Console.WriteLine("count from 1 to 10");
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1) + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("count from 10 to 1");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("2^" + i + " -> " + Math.Pow(2,i) + " ");
            }
            Console.WriteLine("\n");

            int sum = 0;

            for (int i = 0; i < 101; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum of numbers from 1 - 100 : " + sum);

            sum = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }

            }
            Console.WriteLine("project euler problem 1 solution : " + sum);



        }



    }
}
