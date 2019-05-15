using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class ConvertingTypes
    {
        public static void Body() {


            //string to integer
            string age = "10";
            Console.WriteLine($"you are {age} years old"); // you are 10 years old
            Console.WriteLine($"you will be {age + 1} years old next year"); // you are 101 years old
            
            int integerAge = int.Parse(age); 
            Console.WriteLine($"you will be {integerAge+1} years old next year");// you are 11 years old


            string aNumber = "one";
            int result;
            bool canConvert = int.TryParse(aNumber, out result);

            Console.WriteLine($"canConvert \"one\" value is {canConvert}");// false
            Console.WriteLine("convertion result is " + result);

            aNumber = "1";
            canConvert = int.TryParse(aNumber, out result);
            Console.WriteLine($"canConvert \"1\"value is {canConvert}");// true
            Console.WriteLine("convertion result is " + result);

            //integer to string
            int year = 2019;

            string stringYear = year.ToString();
            string last2Digits = stringYear.Substring(2,2);
            Console.WriteLine(last2Digits);

            //operations 
            // +  - *  / %
            Console.WriteLine("1 + 2 = "   + (1 + 2)); //3
            Console.WriteLine("10 - 5  = " + (10 -5)); // 5
            Console.WriteLine("5 * 8  = "  + (5 * 8)); // 40
            Console.WriteLine("10 / 2 = "  + (10 / 2)); // 5
            Console.WriteLine("10 % 4 = "  + (18 % 4)); // 2

            Console.WriteLine("10 + 5 * 3 = " + (10 + 5 * 3)); //25 
            Console.WriteLine("(10 + 5) * 3 = " + ((10 + 5) * 3)); // 45

            int number1 = 17;
            int number2 = 3;

            //casting to double
            double calculationDivide = (double)number1 / number2;

            Console.WriteLine("calculationDivide = number1 / number2 = " +
                Math.Round(calculationDivide, 2));
        }
    }
}
