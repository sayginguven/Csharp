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

            //read line and sruare root the number
            if (!true)
            {
                Console.WriteLine("give me a number");
                string a = Console.ReadLine();
                int number = int.Parse(a);
                Console.WriteLine(Math.Sqrt(number) + "!");
            }

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
            if (!true)
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

            //jagged array
            if (!true)
            {
                //creating jagged array
                //its not 2d array, its array of arrays [ [], [] ,[] ]
                int[][] jaggedArr = new int[3][];

                jaggedArr[0] = new int[5] { 1, 2, 3, 4, 5 };
                jaggedArr[1] = new int[7] { 100, 44, 1224, 1241, 76245, 7737, 145 };
                jaggedArr[2] = new int[2] { 99, 84 };

                string[][] jaggedArrString = new string[4][] {
                new string[] { "apple", "banana", "mango"},
                new string[] { "brocoli", "carrot", "beans"},
                new string[] { "cashews", "nuts"},
                new string[] { "rice", "kebab", "ramen", "spagetti", "kimchi", "T-bone", "steak"}
            };

                //print all elements
                Functions.greetings("jaggedArrString and these are my elements", ConsoleColor.Blue);
                for (int j = 0; j < jaggedArrString.Length; j++)
                {
                    for (int i = 0; i < jaggedArrString[j].Length; i++)
                    {
                        Console.Write(jaggedArrString[j][i] + " ");
                    }
                    Console.WriteLine();
                }


                //access to the jagged array element
                Console.Write("the value of jaggedArrString[3][4] : ");
                Console.WriteLine(jaggedArrString[3][4]);//kimchi

                //2d jagged array one array. each array element has 2d arrays 
                // [ [,] , [,] , [,] , [,] ]
                double[][,] twoDjaggedArray = new double[4][,] {
                new double[2,5] {
                    { 2.1d,5.3d,7.1d,9.2d,7.5d },
                    { 2.8d, 5.2d, 7.6d, 9.9d, 7.2d }
                },
                new double[1,5] {
                    { 5.2d,2.5d,6.7d,9.1d,1.7d }
                },
                new double[2,6] {
                    { 9.2d,8.5d,5.7d,1.9d,4.7d,7.4d },
                    { 1.8d, 1.2d, 9.5d, 7.7d, 8.9d, 4.7d }
                },
                new double[2,5] {
                    { 2.9d,0.5d,8.7d,2.9d,7.7d },
                    { 2.2d, 1.5d, 0.7d, 9.2d, 7.1d }
                },
            };

                Console.WriteLine(twoDjaggedArray[2][1, 4]);//??
            }

        }

    }
}
