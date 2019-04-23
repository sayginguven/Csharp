using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class ConditionalStatements
    {
        public static void body() {


            //string userInput;
            //Console.Write("how old are you? ");
            //userInput = Console.ReadLine();

            ////convert string to integer
            //int result;
            //bool canCoverted = int.TryParse(userInput, out result);

            ////instead of a constant value, take the calendar year
            //int thisYear = (DateTime.Now).Year;

            ////check if convertion is successfull
            //if (canCoverted){
            //    if (result < 0) {
            //        Console.WriteLine("negative age, hmmm interesting");
            //    } else {
            //        if (result > 100){
            //            Console.WriteLine("you are too old to use a computer!");
            //        } else {
            //            Console.WriteLine($"you were born at {thisYear - result} !");
            //        }
            //    }
            //}
            //else{
            //    Console.WriteLine($"heyyy thats not a age!!");
            //}


            ////And operator &&
            ////Or operator ||
            string weather = "rainy";
            bool haveUmbrella = false;

            if (weather == "rainy" && haveUmbrella) {
                Console.WriteLine("You wont be wet!");
            }

            if (weather == "rainy" && !haveUmbrella) {
                Console.WriteLine("Oh no! You will be wet");
            }

            string program1 = "general programming";
            string program2 = "e-commerce";

            Console.WriteLine("what is your program?");
            string userProgram = Console.ReadLine();

            if (userProgram == program1 || userProgram == program2) {
                Console.WriteLine("you are in IT department");
            } else {
                Console.WriteLine("you are not in IT department");
            }


            //create a random number between 1 - 10
            Random rndnumber = new Random();
            int computerNumber = rndnumber.Next(1,10);
            //user will try to find the number
            Console.WriteLine("guess my number between 1- 10");
            string stringUserGuess = Console.ReadLine();
            int intUserGuess;
            bool itsok = int.TryParse(stringUserGuess, out intUserGuess);
            Console.WriteLine("the invisible number is : " + computerNumber);

            if (itsok)
            {

                if (computerNumber == intUserGuess)
                {
                    Console.WriteLine("you did it!!! you won");
                }
                else if (computerNumber > intUserGuess)
                {
                    Console.WriteLine("Its greater than your guess. sorry");
                }
                else {
                    Console.WriteLine("Its less than your guess. sorry");

                }

            }
            else {
                Console.WriteLine("thats not a number");
            }



            //if user guess is less than the random number print no its greater than your guess
            //if user guess is greater than the random number print no its less than your guess










        }
    }
}
