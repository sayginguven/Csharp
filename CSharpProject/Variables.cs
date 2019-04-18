using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Variables
    {
        public static void body() {
            // this is single line comment
            /****************************** 
             
               this is multi line comment
               boolean value is true or false.
               you have to initialize boolean value before using it
             
             ****************************/
            bool booleanVar = false;
            Console.WriteLine("the boolenVar value is either {0} or {1}", booleanVar, !booleanVar);
            Console.WriteLine("the boolen value is either " + booleanVar + " or " + !booleanVar);
            Console.WriteLine($"the boolen value is either {booleanVar} or {!booleanVar}");
            Console.WriteLine($"the size of boolean is {sizeof(bool)} byte");
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
            Console.WriteLine($"the size of sbyte is {sizeof(sbyte)} byte");
            Console.WriteLine("\n");

            char charVar = 'S';
            Console.WriteLine($"the charVar value is {charVar}");
            Console.WriteLine($"the size of char is {sizeof(char)} bytes");
            Console.WriteLine("\n");

            char charUnideVar = '\u01A9';
            Console.WriteLine($"the charUnideVar value is {charUnideVar}");
            Console.WriteLine("\n");

            decimal decimalVar = 15_415_498_714m;
            Console.WriteLine($"the decimalVar value is {decimalVar}");
            Console.WriteLine("formatted decimalVar is : " + String.Format("{0:n0}", decimalVar));
            Console.WriteLine($"The max value for decimal is : {String.Format("{0:n0}", decimal.MaxValue)}");
            Console.WriteLine($"The min value for decimal is : {String.Format("{0:n0}", decimal.MinValue)}");
            Console.WriteLine($"the size of decimal is {sizeof(decimal)} bytes");
            Console.WriteLine("\n");

            double doubleVar = 3.75d;
            Console.WriteLine($"the doubleVar value is {doubleVar}");
            Console.WriteLine($"The max value for double is : {double.MaxValue}");
            Console.WriteLine($"The min value for double is : {double.MinValue}");
            Console.WriteLine($"the size of double is {sizeof(double)} byte");
            Console.WriteLine("\n");

            float floatVar = 2.99f;
            Console.WriteLine($"the floatVar value is {floatVar}");
            Console.WriteLine($"The max value for float is : {float.MaxValue}");
            Console.WriteLine($"The min value for float is : {float.MinValue}");
            Console.WriteLine($"the size of float is {sizeof(float)} bytes");
            Console.WriteLine("\n");

            int intVar = -12345;
            Console.WriteLine($"the intVar value is {intVar}");
            Console.WriteLine($"The max value for int is : {String.Format("{0:n0}", int.MaxValue)}");
            Console.WriteLine($"The min value for int is : {String.Format("{0:n0}", int.MinValue)}");
            Console.WriteLine($"the size of int is {sizeof(int)} bytes");
            Console.WriteLine("\n");

            uint intUnsignedVar = 12345;
            Console.WriteLine($"the intUnsignedVar value is {intUnsignedVar}");
            Console.WriteLine($"The max value for uint is : {String.Format("{0:n0}", uint.MaxValue)}");
            Console.WriteLine($"The min value for uint is : {String.Format("{0:n0}", uint.MinValue)}");
            Console.WriteLine($"the size of uint is {sizeof(uint)} bytes");
            Console.WriteLine("\n");

            int intBinaryVar = 0b11_0110_1010_1010_1010_0001;
            int intHexadecimalVar = 0x00ff_05ff;
            Console.WriteLine($"the IntBinaryVar value is {intBinaryVar}");
            Console.WriteLine($"the intHexadecimalVar value is {intHexadecimalVar}");
            Console.WriteLine("\n");

            long longVar = 1_234_567_891_234_567L;
            Console.WriteLine($"the longVar value is {longVar}");
            Console.WriteLine($"The max value for long is : {String.Format("{0:n0}", long.MaxValue)}");
            Console.WriteLine($"The min value for long is : {String.Format("{0:n0}", long.MinValue)}");
            Console.WriteLine($"the size of long is {sizeof(long)} bytes");
            Console.WriteLine("\n");

            ulong longUnsignedVar = 9_876_543_210_888_911L;
            Console.WriteLine($"the longUnsignedVar value is {longUnsignedVar}");
            Console.WriteLine($"The max value for ulong is : {String.Format("{0:n0}", ulong.MaxValue)}");
            Console.WriteLine($"The min value for ulong is : {String.Format("{0:n0}", ulong.MinValue)}");
            Console.WriteLine($"the size of ulong is {sizeof(ulong)} bytes");
            Console.WriteLine("\n");


            short shortVar = -5;
            Console.WriteLine($"the shortVar value is {shortVar}");
            Console.WriteLine($"The max value for short is : {String.Format("{0:n0}", short.MaxValue)}");
            Console.WriteLine($"The min value for short is : {String.Format("{0:n0}", short.MinValue)}");
            Console.WriteLine($"the size of short is {sizeof(short)} bytes");
            Console.WriteLine("\n");

            ushort shortUnsignedVar = 10;
            Console.WriteLine($"the shortUnsignedVar value is {shortUnsignedVar}");
            Console.WriteLine($"The max value for ushort is :  {ushort.MaxValue}");
            Console.WriteLine($"The min value for ushort is :{ushort.MinValue}");
            Console.WriteLine($"the size of ushort is {sizeof(ushort)} bytes");
            Console.WriteLine("\n");
        }

    }
}
