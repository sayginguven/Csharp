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


            string testString = "Hellooooo C sharp!   ";
            Console.WriteLine($"original string is \t{testString}");
            Console.WriteLine($"testString.Substring(5) \t{testString.Substring(5)}");
            Console.WriteLine($"testString.Substring(10,7) \t{testString.Substring(10,7)}");
            Console.WriteLine($"testString.Remove(5) \t{testString.Remove(5)}");
            Console.WriteLine($"testString.Remove(5,4) \t{testString.Remove(5,4)}");
            Console.WriteLine(testString.Replace(" sharp!", "#").Trim().ToUpper().Remove(5, 4));
            Console.WriteLine($"to lower case : {testString.ToLower()}");
            Console.WriteLine($"the length of testString is : {testString.Length}");
            Console.WriteLine("\n");

            string e = "my name is ";
            string m = "what ";
            string i = "my name is ";
            string n = "what ";
            string e1 = "my name is ";
            string m1 = "slim shaddy";

            Console.WriteLine(e+m+i+n+e1+m1);
            Console.WriteLine("\n");

            StringBuilder myFavoriteSong = new StringBuilder("LET IT GO!!\n");
            myFavoriteSong.AppendLine("let it go ");
            myFavoriteSong.AppendLine("let it go ");
            myFavoriteSong.AppendLine("can't hold it back anymore ");
            myFavoriteSong.AppendLine("let it go ");
            myFavoriteSong.AppendLine("turn away and slam the door.");
            myFavoriteSong.AppendLine("the perfect girl is gone");
            Console.WriteLine(myFavoriteSong.ToString());



        }

    }
}
