using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables.body();
            //OtherVariables.body();
            //MathLibrary.body();
            //ConvertingTypes.body();
            //ConditionalStatements.body();
            //Loops.body();
            //ArraysLibrary.body();

            greetings("saygin");
            greetings("siamak", ConsoleColor.Blue);
            greetings("sina");
            greetings("daniel");
            sayWelcome("mike");
            sayWelcome("wade", "UBC");

            Console.WriteLine("my add function with 5 and 10 is " + add(5, 10)); // 15;
            Console.WriteLine("my multiply function with 5 and 10 is " + multiply(5, 10));//  50
            Console.WriteLine("my subtract function with 5 and 10 is " + subtract(5, 10));//  -5
            Console.WriteLine("my divide function with 5 and 10 is " + divide(5, 10));//  50

            //                              9             2
            //                multiply(9,2)
            //                18
            Console.WriteLine(multiply(add(4, 5), divide(20,10)));


            add(1,2,4,555,6,7,4,7,44,6,8,5,89);
            Console.WriteLine(add(1,2,3,5,19));

            Console.WriteLine("numberToWords(123) : ");
            numberToWords(123);
            Console.WriteLine();

            Console.WriteLine("numberToWords(1010) : ");
            numberToWords(1010);
            Console.WriteLine();


            Console.WriteLine("numberToWords(1000) : ");
            numberToWords(1000);
            Console.WriteLine();


            Console.WriteLine("numberToWords(-12) : ");
            numberToWords(-12);
            Console.WriteLine();


        }




        /// <summary>
        /// This method is taking 2 parameters. First one is a must. Second one is default color white
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        private static void greetings(string name, ConsoleColor color = ConsoleColor.White) {

            Console.ForegroundColor = color;
            Console.WriteLine($"hello my name is {name}");
        }

        private static void sayWelcome(string name, string school = "ITD") {
            Console.WriteLine($"hello {name}, welcome to {school}");
        }


        /// <summary>
        /// this method will take 2 double values and add them together
        /// we dont need this method since we have the params in the third method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static double add(double a, double b) {
            return a + b ;
        }

        //method overloading
        /// <summary>
        /// this method will take 3 double values and add them together
        /// we dont need this method since we have the params in the third method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private static double add(double a, double b, double c)
        {
            return a + b + c;
        }


        /// <summary>
        /// this method will take any amount of arguments and add them together
        /// </summary>
        /// <param name="args">list of double values</param>
        /// <returns></returns>
        private static double add(params double[] args) {

            StringBuilder sb = new StringBuilder();

            double sum = 0;

            for (int i = 0; i < args.Length; i++){
                sb.Append(args[i].ToString());

                if (i == args.Length - 1) sb.Append(" ");
                else sb.Append(" + ");
                sum += args[i];

            }
            sb.Append("= ");
            sb.Append(sum.ToString());
            Console.WriteLine(sb.ToString());
            return sum;
        }
        private static double multiply(double a, double b)
        {
            return a * b;
        }
        private static double subtract(double a, double b)
        {
            return a - b;
        }
        private static double divide(double a, double b)
        {
            return a / b;
        }

        public static void numberToWords(int number)
        {

            if (number < 0)
            {
                Console.WriteLine("Invalid Value");
            }
            else
            {

                int numberDigit = getDigitCount(number);
                int reversedNumber = reverse(number);

                for (int i = 0; i < numberDigit; i += 1)
                {

                    switch (reversedNumber % 10)
                    {
                        case 1:
                            Console.Write("One ");
                            break;
                        case 2:
                            Console.Write("Two ");
                            break;
                        case 3:
                            Console.Write("Three ");
                            break;
                        case 4:
                            Console.Write("Four ");
                            break;
                        case 5:
                            Console.Write("Five ");
                            break;
                        case 6:
                            Console.Write("Six ");
                            break;
                        case 7:
                            Console.Write("Seven ");
                            break;
                        case 8:
                            Console.Write("Eight ");
                            break;
                        case 9:
                            Console.Write("Nine ");
                            break;
                        case 0:
                            Console.Write("Zero ");
                            break;

                    }
                    reversedNumber /= 10;
                }

            }


        }
        public static int getDigitCount(int number)
        {
            if (number < 0)
            {
                return -1;
            }

            if (number < 10)
            {
                return 1;
            }

            int digits = 0;

            while (number > 0)
            {
                number /= 10;
                digits += 1;
            }

            return digits;

        }
        public static int reverse(int number)
        {

            int reverse = 0;
            int lastDigit;

            int original = number;

            //-456
            if (number < 0)
            {
                number *= -1;
            }
            //456


            while (number > 0)//0
            {
                lastDigit = number % 10;//
                reverse *= 10;//
                reverse += lastDigit;//
                number /= 10;//
            }

            if (original > 0)
            {
                return reverse;
            }
            else
            {
                return reverse * -1;
            }

        }
    }
}
