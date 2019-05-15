using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Functions
    {
        public static void Body() {

            //calling methods with different argumets
            Greetings("saygin");
            //passing the second argument instead of using the default parameter
            Greetings("siamak", ConsoleColor.Blue);

            //another example for methods with default parameters
            SayWelcome("mike");
            SayWelcome("wade", "UBC");


            //using methods with a return value
            //return value will not print (usually) developer needs to print
            Console.WriteLine("my add function with 5 and 10 is " + Add(5, 10)); // 15;
            Console.WriteLine("my multiply function with 5 and 10 is " + Multiply(5, 10));//  50
            Console.WriteLine("my subtract function with 5 and 10 is " + Subtract(5, 10));//  -5
            Console.WriteLine("my divide function with 5 and 10 is " + Divide(5, 10));//  50

            //add(4,5) return 9, divide(20,10) return 2
            //multiply(9,2) return 18
            Console.WriteLine(Multiply(Add(4, 5), Divide(20, 10)));

            //using the params parameter in the add method
            Add(1,2,3,4,5,6,7);
            Console.WriteLine(Add(1, 2, 3, 5, 19));

            //printing the numbers to words 
            //one two three
            Console.WriteLine("numberToWords(123) : ");
            NumberToWords(123);
            Console.WriteLine();

            //one zero one zero
            Console.WriteLine("numberToWords(1010) : ");
            NumberToWords(1010);
            Console.WriteLine();

            //one zero zero zero
            Console.WriteLine("numberToWords(1000) : ");
            NumberToWords(1000);
            Console.WriteLine();


            //invalid value
            Console.WriteLine("numberToWords(-12) : ");
            NumberToWords(-12);
            Console.WriteLine();

            Goodbye("everybody");

            //pass by value
            int number1 = 10;
            Console.WriteLine($"before calling the function the number value is {number1}");
            Console.WriteLine($"the value inside the function is {Functions.IncrementTheValue(number1)}");
            Console.WriteLine($"after calling the function the number value is {number1}");

            double balance = 1000;
            Console.WriteLine($"before calling the function the balance is {balance}");
            Console.WriteLine($"the value inside the function is {Functions.TransferTenDolars(ref balance)}");
            Console.WriteLine($"after ccalling the function the balance is {balance}");



            //pass by reference
            double rad = 5.2d; // radius
            double pi = 3d;

            double pi2 = 3.141592d;
            //Console.WriteLine(Math.PI);
            Console.WriteLine(CalculateCircleArea(rad, pi));//pi is 3 
            Console.WriteLine(CalculateCircleArea(rad, pi2));// more precise result

            //thats a constant value 
            const string ipNumber = "199.23.243.103";
            Console.WriteLine($"ip number is {ipNumber}");
            //ipNumber = ""; // compile error

            int studentId;
            GiveAnId(out studentId);
            studentId = 101;//you can modify later its not a constant value
            Console.WriteLine(studentId);

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters
            //in specifies that this parameter is passed by reference but is only read by the called method.
            //ref specifies that this parameter is passed by reference and may be read or written by the called method.
            //out specifies that this parameter is passed by reference and is written by the called method.

            Console.WriteLine($"The factorial(-10) is {Factorial(-10)}");
            Console.WriteLine($"The factorial(1) is {Factorial(1)}");
            Console.WriteLine($"The factorial(2) is {Factorial(2)}");
            Console.WriteLine($"The factorial(10) is {Factorial(10)}");

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"fibonacci({i}) = {Functions.Fibo(i)}");
            }

            for (int i = 0; i < 10_000; i++)
            {
                if (Functions.IsPerfectNumber(i))
                {
                    Console.WriteLine(i);
                }

            }
        }

        public static int Decrement1or2or5(int userData)
        {

            //negative control
            if (userData < 0)
            {
                Console.WriteLine("be positive...");
                return 0;
            }

            // -1 GAME OVER
            if (userData == 0)
            {
                Console.WriteLine("YOU LOST!");
                return -1;
            }


            //-1 GAME OVER
            if (userData == 1)
            {
                Console.WriteLine("I LOST");
                return -1;
            }

            //computer wins
            if (userData == 2)
            {
                Console.Write($"My number is         ");
                PrintWithColor("1", ConsoleColor.Blue, ConsoleColor.White);
                Console.WriteLine();
                return 1;
            }

            //randomly return userData-2 or userData-5
            if (userData % 3 == 0)
            {
                Random random = new Random();
                int random1or2 = random.Next(1, 3);
                int deductNumber = 0;
                if (random1or2 == 1) deductNumber = 2;
                if (random1or2 == 2) deductNumber = 5;

                if (userData == 3) deductNumber = 2;

                Console.Write($"My number is         ");
                PrintWithColor((userData - deductNumber).ToString(), ConsoleColor.Blue, ConsoleColor.White);
                Console.WriteLine();
                return userData - deductNumber;
            }


            //computer may lose
            //return random number userData-1 or userData-2 or  userData-5 
            if (((userData - 1) % 3) == 0)
            {
                Random random = new Random();
                int random1or2or3 = random.Next(1, 4);
                int deductNumber = 0;
                if (random1or2or3 == 1) deductNumber = 1;
                if (random1or2or3 == 2) deductNumber = 2;
                if (random1or2or3 == 3) deductNumber = 5;

                Console.Write($"My number is         ");
                PrintWithColor((userData - deductNumber).ToString(), ConsoleColor.Blue, ConsoleColor.White);
                Console.WriteLine();
                return userData - deductNumber;
            }


            if (((userData + 1) % 3) == 0)
            {
                Console.Write($"My number is         ");
                PrintWithColor((userData - 1).ToString(), ConsoleColor.Blue, ConsoleColor.White);
                Console.WriteLine();
                return userData - 1;
            }

            return -1;

        }

        public static void PrintWithColor(string message, ConsoleColor color, ConsoleColor colorReset)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ForegroundColor = colorReset;
        }

        public static void GameRules()
        {
            Console.WriteLine("\tCAN YOU BEAT MY AI?");
            Console.WriteLine("\tTHESE ARE THE RULES");
            Console.WriteLine("\tYou will start with a number which is greater than 50");
            Console.Write("\tWe will decrement the number by ");
            PrintWithColor("\t1 or 2 or 5\n", ConsoleColor.DarkYellow, ConsoleColor.White);
            Console.WriteLine("\tWhoever enters 0 will lose");
            Console.WriteLine("\n");
        }

        public static void Game()
        {

            bool gameover = false;
            bool firstRound = true;
            int userInput = 0;
            int computerCalculation = 0;
            string userInputString;

            while (!gameover)
            {

                if (firstRound)
                {
                    GameRules();
                }

                //get user, output with dark green color
                Console.Write("What is your number? ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                userInputString = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                bool validatedInput = int.TryParse(userInputString, out userInput);


                //starting number is 50 or more.
                if (userInput < 50 && firstRound && validatedInput)
                {
                    PrintWithColor($"I think {userInput.ToString()} is not greater than 50. Please read the rules.\n", ConsoleColor.Red, ConsoleColor.White);
                    continue;
                }


                //game rules and valudation control 
                //firstRound flag will change
                if (computerCalculation - 1 == userInput || 
                    computerCalculation - 2 == userInput || 
                    computerCalculation - 5 == userInput || 
                    firstRound && validatedInput)
                {

                    computerCalculation = Decrement1or2or5(userInput);
                    firstRound = false;
                    if (computerCalculation == -1)
                    {
                        PrintWithColor("do you want to play again? Y or N : ", ConsoleColor.Green, ConsoleColor.White);
                        string userYesNo = Console.ReadLine();
                        if (userYesNo == "Y" || userYesNo == "y")
                        {
                            firstRound = true;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Thank you");
                            gameover = true;
                        }
                    }
                }
                else if (!validatedInput)
                {
                    Console.Write("hmm I think ");
                    PrintWithColor(userInputString, ConsoleColor.DarkRed, ConsoleColor.White);
                    Console.WriteLine(" is not a number, try again");
                }
                else
                {
                    Console.Write($"You need to decrement {computerCalculation} by ");


                    //print the hint for user
                    if ((computerCalculation - 5) > 0)
                    {
                        PrintWithColor("1", ConsoleColor.Red, ConsoleColor.White);
                        Console.Write(" or ");
                        PrintWithColor("2", ConsoleColor.Red, ConsoleColor.White);
                        Console.Write(" or ");
                        PrintWithColor("5", ConsoleColor.Red, ConsoleColor.White);
                        Console.Write($"   such as {computerCalculation - 1} or {computerCalculation - 2} or {computerCalculation - 5}");
                    }
                    else if ((computerCalculation - 5) < 0 && (computerCalculation - 2) > 0)
                    {
                        PrintWithColor("1", ConsoleColor.Red, ConsoleColor.White);
                        Console.Write(" or ");
                        PrintWithColor("2", ConsoleColor.Red, ConsoleColor.White);
                        Console.Write($"   such as {computerCalculation - 1} or {computerCalculation - 2} ");
                    }
                    else
                    {
                        PrintWithColor("1", ConsoleColor.Red, ConsoleColor.White);
                        Console.Write($"   such as {computerCalculation - 1} :)");
                    }


                    Console.WriteLine();

                    
                }
            }
        }


        /// <summary>
        /// print the value with a selected color
        /// </summary>
        /// <param name="name">user name</param>
        /// <param name="color">default parameter color is white</param>
        public static void Greetings(string name, ConsoleColor color = ConsoleColor.White)
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
        public static void SayWelcome(string name, string school = "ITD")
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
        public static double Add(double a, double b)
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
        public static double Add(double a, double b, double c)
        {
            return a + b + c;
        }


        /// <summary>
        /// this method will take any amount of arguments and add them together
        /// </summary>
        /// <param name="args">list of double values</param>
        /// <returns></returns>
        public static double Add(params double[] args)
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
        public static double Multiply(double a, double b)
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
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// basic divide without exception control
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Divide(double a, double b)
        {
            return a / b;
        }


        /// <summary>
        /// printing the number to words
        /// 123 -> one two three
        /// </summary>
        /// <param name="number"></param>
        public static void NumberToWords(int number)
        {

            if (number < 0)
            {
                Console.WriteLine("Invalid Value");
            }
            else
            {

                int numberDigit = GetDigitCount(number);
                int reversedNumber = Reverse(number);

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
        public static int GetDigitCount(int number)
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
        public static int Reverse(int number)
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
        public static void Goodbye(string str) => Console.WriteLine("goodbye " + str);


        //pass by value
        public static int IncrementTheValue(int a) {
            a += 1;
            return a;
        }
        //pass by reference
        public static double TransferTenDolars(ref double money) {
            money -= 10.0;
            return money;
        }

        //pi value is constant will not change
        public static double CalculateCircleArea(double radius, in double pi)
        {
            return pi * radius * radius;
        }

        //id must be initialized inside the method
        public static void GiveAnId(out int id)
        {
            id = 100;
        }


        //recursive functions
        public static int Factorial(int number) {
            if (number <= 0) {
                return -1;

            }else if  (number == 1) {
                return 1;
            }
            else {
                return number * Factorial(number - 1);
            }
        }

        //fibonacci series
        public static long Fibo(int number) {

            if (number == 0) {
                return 0;
            }

            if (number == 1) {
                return 1;
            }

            return Fibo(number - 1) + Fibo(number - 2);

        }

        public static int AddArrayElements(int[] arr) {

            int sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }

        public static void PrintFactors(int n) {

            if (n < 1) {
                Console.WriteLine("Invalid Value");
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) {
                    Console.Write(i + " ");
                }
            }
        }

        public static bool IsPerfectNumber(int n) {
            if (n < 1) return false;
            if (n == 1) return true;
            
            int sum = 0;

            for (int i = 1; i <= n/2; i++)
                if (n % i == 0) sum += i;

            if (sum == n) return true;
            else return false;
        }

        public static bool IsPrime(int number) {
            //TODO implement this
            return false;
        }

    }
}
