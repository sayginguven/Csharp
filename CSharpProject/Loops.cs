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

            //while loop
            if (!true)
            {
                int i=0;
                while (i < 10)
                {
                    Console.WriteLine(i);
                    i += 1;
                }

                i = 10;
                while(i >0){
                    i -= 1;
                    if (i == 5) continue;
                    Console.WriteLine(i);
                }

            }

            //average number calculator 
            if (!true)
            {
                int userInput=0, total=0, counter=0;

                Console.WriteLine("AVERAGE NUMBER CALCULATOR");
                while (userInput != -1)
                {
                    Console.Write($"What is the number # {counter+1}? ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    bool parseOk = int.TryParse(Console.ReadLine(), out userInput);
                    if (parseOk)
                    {
                        if (userInput > 100) {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("the max is 100! please try again");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }

                        if (userInput< -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("the min number is 0! press -1 to exit. please try again");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        if (userInput == -1) break;
                        total += userInput;
                        counter += 1;
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("thats not a number!");
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                }
                //todo
                //calculate the average
                Console.Write($"You have provided {counter} numbers and the average is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{ Math.Round((double)total / counter, 2)}");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n\n\n");
            }

            //do while loop 
            if (true)
            {
                int a = 1;
                while (a > 10) {
                    Console.WriteLine(a + " is a great number");
                    a += 10;
                }

                //do while loop will run at least 1 time no matter what is the while condition
                int b = 1;
                do
                {
                    Console.WriteLine(b + " is a great number");
                    b += 1;
                } while (b >10);
            }

        }
    }
}

    

    

