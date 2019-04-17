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
            // this is single line comment
            /****************************** 
             
               this is multi line comment
               boolean value is true or false.
               you have to initialize boolean value before using it
             
             ****************************/
            bool booleanVar = false;
            Console.WriteLine("the boolenVar value is either {0} or {1}", booleanVar,!booleanVar);
            Console.WriteLine("the boolenVar value is either " + booleanVar + " or " + !booleanVar);
            Console.WriteLine($"the boolenVar value is either {booleanVar} or {!booleanVar}");




            Console.ReadLine();
        }
    }
}
