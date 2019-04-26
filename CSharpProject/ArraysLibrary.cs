using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class ArraysLibrary
    {
        public static void body() {
        
            //create a students array
            string[] students = { "siamak", "sina", "daniel", "jose",
                                  "mariana", "alex", "naoya", "wade",
                                  "mykhailo"
                                };

            //sort the array in alphabetic order
            Console.WriteLine("sorted students A-Z");
            Array.Sort(students);

            //print the array in alphabetic order
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");


            //reverse the string 
            Array.Reverse(students);
            Console.WriteLine("sorted students Z-A");
            //print the array in reversed alphabetic order
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            
            //create int array with 10 elements
            int[] numbers = new int[10] { 10, 40, 20,30,50,70,80,90, 100,60 };


            //print the numbers array with for loop
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
            Console.WriteLine("\n");

            //clear the array index from 1-5
            Array.Clear(numbers, 1, 6);

            //extend array size to 15
            Array.Resize(ref numbers, 15);

            //sort the array
            Array.Sort(numbers);

            //reverse the array
            Array.Reverse(numbers);


            //print the arrays 
            Console.WriteLine("printing resized, sorted and reversed array");
            foreach (int element in numbers) {
                Console.WriteLine(element);
            }


            //check the index of a number
            Console.WriteLine("555 is in the index of " + Array.IndexOf(numbers, 555)); // -1 means its not in the array
            Console.WriteLine("100 is in the index of " + Array.IndexOf(numbers, 100)); // 0 means its index 0
        }

    }
}
