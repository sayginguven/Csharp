using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class OtherVariables
    {
        enum weekDays
        {
            Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        struct dog {
            public int birthYear;
            public string name;
            public bool isFriendly;

            public void whoYouAre() {
                Console.WriteLine($"Hello my name is {name}, " +
                $"I was born at {birthYear} " +
                $"people say I am friendly thats {isFriendly}.");
            }
        }

        public static void body() {
            Console.WriteLine("enum print");
            Console.WriteLine($"the enum weekdays monday is : {weekDays.Monday.ToString()}");
            Console.WriteLine($"the enum weekdays monday value is : {(int)weekDays.Monday}");
            Console.WriteLine("\n");

            dog doggy;
            doggy.birthYear = 2019;
            doggy.name = "sparky";
            doggy.isFriendly = true;
            doggy.whoYouAre();

            Console.WriteLine("\n");
            Console.WriteLine("\t this is tab");
            Console.WriteLine("/\\ /\\");
            Console.WriteLine("she said \"yes\"");
            Console.WriteLine("helll\boo");
            Console.WriteLine("\a");
            Console.Write("this is the symbol of PI \u03C0");
            Console.WriteLine("\n");


            


        }

    }
}
