using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Loops
    {
        public static void body()
        {

            //for loop
            if (!true)
            {
                for (int i = 0; i < 10; i += 1)
                {
                    Console.WriteLine($"{i + 1} I wont sleep in the class again");
                }

                Console.WriteLine("count from 1 to 10");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write((i + 1) + " ");
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
                    Console.Write("2^" + i + " -> " + Math.Pow(2, i) + " ");
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
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        sum += i;
                    }

                }
                Console.WriteLine("project euler problem 1 solution : " + sum);
            }

            //infinite loop
            if (!true)
            {
                for (int i = 10; i > 0; i++)
                    {
                        Console.WriteLine("the value of i is {0}", i);
                    }

                //infinite loop with no initilizer and condition
                for (; ; )
                {

                }
            }

            //break and continue keywords and using multiple initilazed variables
            if (!true)
            {
                for (int i = 1; i < 100; ++i)
                {
                    if (i % 2 == 0) continue;
                    Console.WriteLine(i);
                    if (i == 15) break;
                }

                //only any only 1 line of code will be part of for loop
                //if there is no curly bracets
                for (double i = 1.1d; i < 2; i += .1)
                    Console.WriteLine(i);
                Console.WriteLine("next");//this line of code is not part of for loop


                Console.WriteLine("\n\n\n");

                Console.WriteLine("i -- j");
                // && j>8 part is extra condition 
                for (int i = 0, j = 729; i < 10 /*&& j>8*/; i += 2, j /= 3)
                {
                    Console.WriteLine("{0} -- {1}", i, j);
                }
            }


        }
    }
}

    

    

