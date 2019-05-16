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

            string separator = new string('#', 40);

            Console.WriteLine("enum print");
            Console.WriteLine($"the enum weekdays monday is : {weekDays.Monday.ToString()}");
            Console.WriteLine($"the enum weekdays monday value is : {(int)weekDays.Monday}");

            Console.WriteLine(separator);

            dog doggy;
            doggy.birthYear = 2019;
            doggy.name = "sparky";
            doggy.isFriendly = true;
            doggy.whoYouAre();
            Console.WriteLine(separator);

            Console.WriteLine("\n");
            Console.WriteLine("\t this is tab");
            Console.WriteLine("/\\ /\\");
            Console.WriteLine("she said \"yes\"");
            Console.WriteLine("helll\boo");
            //Console.WriteLine("\a"); alert sound
            Console.Write("this is the symbol of PI \u03C0 \n");
            Console.WriteLine(separator);


            string testString = "Hellooooo C sharp!   ";
            Console.WriteLine($"original string is \t{testString}");
            Console.WriteLine($"testString.Substring(5) \t{testString.Substring(5)}");
            Console.WriteLine($"testString.Substring(10,7) \t{testString.Substring(10,7)}");
            Console.WriteLine($"testString.Remove(5) \t{testString.Remove(5)}");
            Console.WriteLine($"testString.Remove(5,4) \t{testString.Remove(5,4)}");
            Console.WriteLine(testString.Replace(" sharp!", "#").Trim().ToUpper().Remove(5, 4));
            Console.WriteLine($"to lower case : {testString.ToLower()}");
            Console.WriteLine($"the length of testString is : {testString.Length}");
            Console.WriteLine(separator);

            string e = "my name is ";
            string m = "what ";
            string i = "my name is ";
            string n = "what ";
            string e1 = "my name is ";
            string m1 = "slim shaddy";

            Console.WriteLine(e+m+i+n+e1+m1);
            Console.WriteLine(separator);

            StringBuilder myFavoriteSong = new StringBuilder("LET IT GO!!\n");
            myFavoriteSong.AppendLine("let it go ");
            myFavoriteSong.AppendLine("let it go ");
            myFavoriteSong.AppendLine("can't hold it back anymore ");
            myFavoriteSong.AppendLine("let it go ");
            myFavoriteSong.AppendLine("turn away and slam the door.");
            myFavoriteSong.AppendLine("the perfect girl is gone");
            Console.WriteLine(myFavoriteSong.ToString());
            Console.WriteLine(separator);

            string myFolderPath1 = "C:\\Users\\saygin.guven\\Documents\\CSharpProject\\CSharpProject";
            string myFolderPath2 = @"C:\Users\saygin.guven\Documents\CSharpProject\CSharpProject";

            string myString = "myke,wade,alex,naoya,jose,mariana,daniel,sina,siamak";
            string[] splittedString = myString.Split(new char[] {','});// you can add more char like this{',',';'} 

            foreach (string element in splittedString)
            {
                Console.WriteLine(element);
            }
            //for (int j = 0; j < splittedString.Length; j += 1) {
            //    Console.WriteLine(splittedString[j]);
            //}
            Console.WriteLine(separator);

            Console.WriteLine($"full time is : {DateTime.Now}");
            Console.WriteLine($"full time is : {string.Format("{0:t}",DateTime.Now)}");
            Console.WriteLine($"full time is : {string.Format("{0:T}",DateTime.Now)}");
            Console.WriteLine($"full time is : {DateTime.Now.ToString("MMMM dd, yyyy")}");
            Console.WriteLine($"full time is : {DateTime.Now.ToString("MMMM dd, yyyy H:mm:ss dddd")}");

            DateTime myBirthDay = new DateTime(1983, 6, 17);
            Console.WriteLine($"{myBirthDay.Year}, {myBirthDay.Month}, {myBirthDay.Day} ");



            Console.WriteLine(separator);




            string dolly = "I am a sheep";
            string dollysTwin = "I am a sheep too";
            string dollysTriplet = string.Copy(dolly);
            object clonedDolly = dolly.Clone();
            Console.WriteLine(clonedDolly.ToString());

            int compareResult = string.Compare(dolly, clonedDolly.ToString());//0 means same
            Console.WriteLine($"compare dolly and cloned dolly : {compareResult}");

            int compareTwinResult = string.Compare(dolly, dollysTwin);//-1 means not same
            Console.WriteLine($"compare dolly and dollysTwin : {compareTwinResult}");

            int compareTripletResult = string.Compare(dolly, dollysTriplet);//0 means same
            Console.WriteLine($"compare dolly and dollysTriptlet : {compareTripletResult}");

            string s1 = "Talk is cheap, show me the code. Linus Torvalds";
            string s2 = "cheap";
            bool containsBoolean = s1.Contains(s2);
            Console.WriteLine($"is \"{s1}\" contains {s2}? answer : { containsBoolean} ");
            Console.WriteLine($"{s1.IndexOf(s2)}");

        }
    }
}
