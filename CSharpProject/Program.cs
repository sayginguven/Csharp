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
            Console.WriteLine($"the size of boolen is {sizeof(bool)} byte");
            Console.WriteLine("\n");


            byte byteVar = 1;
            Console.WriteLine($"the byteVar value is {byteVar}");
            Console.WriteLine($"The max value for byte is : {byte.MaxValue}");
            Console.WriteLine($"The min value for byte is : {byte.MinValue}");
            Console.WriteLine($"the size of byte is {sizeof(byte)} byte");
            Console.WriteLine("\n");

            sbyte sbyteVar = 2;
            Console.WriteLine($"the sbyteVar value is {sbyteVar}");
            Console.WriteLine($"The max value for sbyte is : {sbyte.MaxValue}");
            Console.WriteLine($"The min value for sbyte is : {sbyte.MinValue}");
            Console.WriteLine($"the size of byte is {sizeof(sbyte)} byte");
            Console.WriteLine("\n");

            char charVar = 'S';
            Console.WriteLine($"the charVar value is {charVar}");
            Console.WriteLine($"the size of char is {sizeof(char)} bytes");
            Console.WriteLine("\n");

            char charVarUnide = '\u01A9';
            Console.WriteLine($"the charVarUnide value is {charVarUnide}");
            Console.WriteLine("\n");

            decimal decimalVar = 15_415_498_714m;
            Console.WriteLine($"the decimalVar value is {decimalVar}");
            Console.WriteLine("formatted decimalVar is : "+ String.Format("{0:n0}",decimalVar));
            Console.WriteLine($"The max value for decimal is : {String.Format("{0:n0}",decimal.MaxValue)}");
            Console.WriteLine($"The min value for decimal is : {String.Format("{0:n0}", decimal.MinValue)}");
            Console.WriteLine($"the size of decimal is {sizeof(decimal)} bytes");
            Console.WriteLine("\n");

            double doubleVar = 3.75d;
            Console.WriteLine($"the doubleVar value is {doubleVar}");
            Console.WriteLine($"The max value for double is : {double.MaxValue}");
            Console.WriteLine($"The min value for double is : {double.MaxValue}");
            Console.WriteLine($"the size of double is {sizeof(double)} byte");
            Console.WriteLine("\n");

            float floatVar = 2.99f;
            Console.WriteLine($"the floatVar value is {floatVar}");
            Console.WriteLine($"The max value for float is : {float.MaxValue}");
            Console.WriteLine($"The min value for float is : {float.MaxValue}");
            Console.WriteLine($"the size of float is {sizeof(float)} byte");
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
