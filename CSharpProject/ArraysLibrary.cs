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


            Console.WriteLine("give me a number");
            string a = Console.ReadLine();
            int number = int.Parse(a);
            Console.WriteLine(Math.Sqrt(number)+ "!");


            //array
            if (!true)
            {
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
                int[] numbers = new int[10] { 10, 40, 20, 30, 50, 70, 80, 90, 100, 60 };


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
                foreach (int element in numbers)
                {
                    Console.WriteLine(element);
                }

                //check the index of a number
                Console.WriteLine("555 is in the index of " + Array.IndexOf(numbers, 555)); // -1 means its not in the array
                Console.WriteLine("100 is in the index of " + Array.IndexOf(numbers, 100)); // 0 means its index 0

            }

            //multidimensional  array
            if (!true)
            {
                //multidimensional arrays
                //2d array                y,x
                int[,] twodim = new int[2, 4] {
                { 1,2,3,4},
                { 21,22,23,24}
            };


                //3d array                 z, y, x
                int[,,] threedim = new int[3, 2, 4] {
                {
                  {1,2,3,4},
                  {5,6,7,8}
                },
                {
                  {11,22,33,44},
                  {55,66,77,88}
                },
                {
                 {111,222,333,444 },
                 {555,666,777,888}
                }
            };


                Console.WriteLine(threedim[1, 1, 3]);// 88

                //four ultidimensional array dont do this!
                //                       t, z, y, x
                int[,,,] fourD = new int[1, 2, 3, 4] {
                {
                    {
                      {1,2,3,4},
                      {5,6,7,8},
                      {9,10,11,12}
                    },
                    {
                      {11,22,33,44},
                      {55,66,77,88},
                      {99,1010,1111,1212}
                    }
                }
            };

                Console.WriteLine(fourD[0, 1, 2, 2]);//1111
            }
            
            //initilize 2d array
            if (true)
            {
                float[,] floarArr = new float[2, 5];

                Console.WriteLine($"the length of floatArr is : {floarArr.Length}");
                Console.WriteLine($"the length of floatArr[i] is : {floarArr.GetLength(0)}");
                Console.WriteLine($"the length of floatArr[j] is : {floarArr.GetLength(1)}");

                for (int i = 0; i < floarArr.GetLength(0); i += 1)
                {
                    for (int j = 0; j < floarArr.GetLength(1); j += 1)
                    {
                        floarArr[i, j] = i * floarArr.GetLength(1) + j + 1;
                    }
                }

                //print two dimensional array
                for (int i = 0; i < floarArr.GetLength(0); i += 1)
                {
                    for (int j = 0; j < floarArr.GetLength(1); j += 1)
                    {
                        Console.WriteLine($"floatArr[{i},{j}] = {floarArr[i, j]}");
                    }
                }


            }


        }

    }
}
