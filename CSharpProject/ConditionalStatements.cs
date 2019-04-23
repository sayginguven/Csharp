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


            string userInput;
            Console.Write("how old are you? ");
            userInput = Console.ReadLine();

            //convert string to integer
            int result;
            bool canCoverted = int.TryParse(userInput, out result);

            //instead of a constant value, take the calendar year
            int thisYear = (DateTime.Now).Year;

            //check if convertion is successfull
            if (canCoverted){
                if (result < 0) {
                    Console.WriteLine("negative age, hmmm interesting");
                } else {
                    Console.WriteLine($"you were born at {thisYear - result} !");
                }
            }
            else{
                Console.WriteLine($"heyyy thats not a age!!");
            }





        }
    }
}
