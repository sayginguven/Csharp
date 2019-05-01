using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Functions
    {
        public static void body() {

            //calling methods with different argumets
            greetings("saygin");
            //passing the second argument instead of using the default parameter
            greetings("siamak", ConsoleColor.Blue);

            //another example for methods with default parameters
            sayWelcome("mike");
            sayWelcome("wade", "UBC");


            //using methods with a return value
            //return value will not print (usually) developer needs to print
            Console.WriteLine("my add function with 5 and 10 is " + add(5, 10)); // 15;
            Console.WriteLine("my multiply function with 5 and 10 is " + multiply(5, 10));//  50
            Console.WriteLine("my subtract function with 5 and 10 is " + subtract(5, 10));//  -5
            Console.WriteLine("my divide function with 5 and 10 is " + divide(5, 10));//  50

            //add(4,5) return 9, divide(20,10) return 2
            //multiply(9,2) return 18
            Console.WriteLine(multiply(add(4, 5), divide(20, 10)));

            //using the params parameter in the add method
            add(1,2,3,4,5,6,7);
            Console.WriteLine(add(1, 2, 3, 5, 19));

            //printing the numbers to words 
            //one two three
            Console.WriteLine("numberToWords(123) : ");
            numberToWords(123);
            Console.WriteLine();

            //one zero one zero
            Console.WriteLine("numberToWords(1010) : ");
            numberToWords(1010);
            Console.WriteLine();

            //one zero zero zero
            Console.WriteLine("numberToWords(1000) : ");
            numberToWords(1000);
            Console.WriteLine();


            //invalid value
            Console.WriteLine("numberToWords(-12) : ");
            numberToWords(-12);
            Console.WriteLine();

            goodbye("everybody");

            //pass by value
            int number1 = 10;
            Console.WriteLine($"before calling the function the number value is {number1}");
            Console.WriteLine($"the value inside the function is {Functions.incrementTheValue(number1)}");
            Console.WriteLine($"after calling the function the number value is {number1}");

            double balance = 1000;
            Console.WriteLine($"before calling the function the balance is {balance}");
            Console.WriteLine($"the value inside the function is {Functions.transferTenDolars(ref balance)}");
            Console.WriteLine($"after ccalling the function the balance is {balance}");



            //pass by reference
            double rad = 5.2d; // radius
            double pi = 3d;

            double pi2 = 3.141592d;
            //Console.WriteLine(Math.PI);
            Console.WriteLine(calculateCircleArea(rad, pi));//pi is 3 
            Console.WriteLine(calculateCircleArea(rad, pi2));// more precise result

            //thats a constant value 
            const string ipNumber = "199.23.243.103";
            //ipNumber = ""; // compile error

            int studentId;
            giveAnId(out studentId);
            studentId = 101;//you can modify later its not a constant value
            Console.WriteLine(studentId);

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters
            //in specifies that this parameter is passed by reference but is only read by the called method.
            //ref specifies that this parameter is passed by reference and may be read or written by the called method.
            //out specifies that this parameter is passed by reference and is written by the called method.

        }
        /// <summary>
        /// print the value with a selected color
        /// </summary>
        /// <param name="name">user name</param>
        /// <param name="color">default parameter color is white</param>
        public static void greetings(string name, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"hello my name is {name}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        ///  printing a welcome message to user
        /// </summary>
        /// <param name="name">user name</param>
        /// <param name="school">default parameter is ITD</param>
        public static void sayWelcome(string name, string school = "ITD")
        {
            Console.WriteLine($"hello {name}, welcome to {school}");
        }


        /// <summary>
        /// this method will take 2 double values and add them together
        /// we dont need this method since we have the params in the third method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double add(double a, double b)
        {
            return a + b;
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
        public static double add(double a, double b, double c)
        {
            return a + b + c;
        }


        /// <summary>
        /// this method will take any amount of arguments and add them together
        /// </summary>
        /// <param name="args">list of double values</param>
        /// <returns></returns>
        public static double add(params double[] args)
        {

            StringBuilder sb = new StringBuilder();

            double sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
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
        /// <summary>
        ///     basic multiply method 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double multiply(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        ///     basic subtract method
        ///     a-b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// basic divide without exception control
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double divide(double a, double b)
        {
            return a / b;
        }


        /// <summary>
        /// printing the number to words
        /// 123 -> one two three
        /// </summary>
        /// <param name="number"></param>
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

        /// <summary>
        /// get the length of number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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

        /// <summary>
        /// reverse an integer value 
        /// 123 -> s321
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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

        //one line of scope alternative method
        public static void goodbye(string str) => Console.WriteLine("goodbye " + str);


        //pass by value
        public static int incrementTheValue(int a) {
            a += 1;
            return a;
        }
        //pass by reference
        public static double transferTenDolars(ref double money) {
            money -= 10.0;
            return money;
        }

        //pi value is constant will not change
        public static double calculateCircleArea(double radius, in double pi)
        {
            return pi * radius * radius;
        }

        //id must be initialized inside the method
        public static void giveAnId(out int id)
        {
            id = 100;
        }

    }
}
