using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class ConditionalStatements
    {
        public static void Body() {

            //change the tests in the if statements to be able to run the code
            bool test = false;

            //birth year calculator based on age
            if (test) {
                string userInput;
                Console.Write("how old are you? ");
                userInput = Console.ReadLine();

                ////convert string to integer
                int result;
                bool canCoverted = int.TryParse(userInput, out result);

                //instead of a constant value, take the calendar year
                int thisYear = (DateTime.Now).Year;

                //check if convertion is successfull
                if (canCoverted)
                {
                    if (result < 0)
                    {
                        Console.WriteLine("negative age, hmmm interesting");
                    }
                    else
                    {
                        if (result > 100)
                        {
                            Console.WriteLine("you are too old to use a computer!");
                        }
                        else
                        {
                            Console.WriteLine($"you were born at {thisYear - result} !");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"heyyy thats not a age!!");
                }
            }

            //and or operators 
            if (test) {
                //And operator &&
                //Or operator ||
                string weather = "rainy";
                bool haveUmbrella = false;

                if (weather == "rainy" && haveUmbrella)
                {
                    Console.WriteLine("You have umbrella and its rainny. Don't worry you wont be wet!");
                }

                if (weather == "rainy" && !haveUmbrella)
                {
                    Console.WriteLine("Oh no! You dont have an umbrella and its rainny. You will be wet");
                }


                Console.WriteLine("____Chose your program____");
                Console.WriteLine("_a -\tGeneral Programming");
                Console.WriteLine("_b -\tE-commerce");
                Console.WriteLine("_c -\tGraphic Design");
                Console.WriteLine("_d -\tInterior Design");
                Console.WriteLine("_e -\tHospitality");

                string userProgram = Console.ReadLine();
                userProgram = userProgram.ToLower();

                switch (userProgram)
                {
                    case "a":
                    case "b":
                        Console.WriteLine("you are in IT department");
                        break;
                    case "c":
                    case "d":
                        Console.WriteLine("you are in ART department");
                        break;
                    case "e":
                        Console.WriteLine("you are in HOSPITALITY department");
                        break;
                    default:
                        Console.WriteLine("oops its not in the menu");
                        break;
                }

            }

            //random number and guess game
            if (test) {
                //create a random number between 1 - 10
                Random rndnumber = new Random();
                int computerNumber = rndnumber.Next(1, 10);
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
                    else
                    {
                        Console.WriteLine("Its less than your guess. sorry");

                    }

                }
                else
                {
                    Console.WriteLine("thats not a number");
                }
            }

            //switch statement and when case
            if (test) {
                Console.WriteLine("menu");
                Console.WriteLine("1- option 1");
                Console.WriteLine("2- option 2");
                Console.WriteLine("3- option 3");
                Console.WriteLine("4- option 4");
                Console.WriteLine("5- option 5");
                Console.WriteLine("6- option 6");

                Console.WriteLine("select one of the options");

                string userOption = Console.ReadLine();

                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("you have selected 1");
                        break;
                    case "2":
                        Console.WriteLine("you have selected 2");
                        break;
                    case "3":
                        Console.WriteLine("you have selected 3");
                        break;
                    case "4":
                        Console.WriteLine("you have selected 4");
                        break;
                    case "5":
                        Console.WriteLine("you have selected 5");
                        break;
                    case "6":
                        Console.WriteLine("you have selected 6");
                        break;
                    default:
                        Console.WriteLine($"{userOption} is not in the menu");
                        break;
                }

                //Switch statement alternative is if else
                //However switch statement is easy to read and maintain
                //if (userOption == "1")
                //{
                //    Console.WriteLine("you have selected 1");
                //}
                //else if (userOption == "2")
                //{
                //    Console.WriteLine("you have selected 2");

                //}
                //else if (userOption == "3")
                //{
                //    Console.WriteLine("you have selected 3");

                //}
                //else if (userOption == "4")
                //{
                //    Console.WriteLine("you have selected 4");

                //}
                //else if (userOption == "5")
                //{
                //    Console.WriteLine("you have selected 5");

                //}
                //else if (userOption == "6")
                //{
                //    Console.WriteLine("you have selected 6");

                //}
                //else
                //{
                //    Console.WriteLine($"{userOption} is not in the menu");

                //}


                Console.WriteLine("hey how old are you?");
                string userAge = Console.ReadLine();

                int ageResult;
                bool ageOk = int.TryParse(userAge, out ageResult);
                if (ageOk)
                {
                    switch (ageResult)
                    {
                        //microsoft introduced when keyword in C# 7.0
                        case int ageCheck when ageCheck < 0:
                            Console.WriteLine("Its invalid age. sorry.");
                            break;
                        case int ageCheck when /*ageCheck > 0 &&*/ ageCheck <= 5:
                            Console.WriteLine("You are a kid");
                            break;
                        case int ageCheck when /*ageCheck > 0 &&*/ ageCheck <= 12:
                            Console.WriteLine("You are youth");
                            break;
                        case int ageCheck when /*ageCheck > 12 &&*/ ageCheck <= 17:
                            Console.WriteLine("You are teenager!");
                            break;
                        case int ageCheck when /*ageCheck >= 18 &&*/ ageCheck < 100:
                            Console.WriteLine("You are adult");
                            break;
                        case int ageCheck when /*ageCheck >= 100 &&*/ ageCheck <= 120:
                            Console.WriteLine("You are old! so old! too old!");
                            break;
                        default:
                            Console.WriteLine("You are dead");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("thats not a digit");
                }





            }

            //ternary operator
            if (test) {
                // ? : operator
                // short if

                string adultOrNot; // "adult" // "not adult" 

                int age = 25;

                adultOrNot = (age > 18) ? "adult" : "not adult";

                Console.WriteLine($"your age is {age} and you are {adultOrNot}");
            }

        }
    }
}
