using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PolymorphismTest();

            Hashtable hashtab = new Hashtable();
            Dictionary<string, string> dict = new Dictionary<string, string>();

        }

        public static void ArrayListTest() {
            ArrayList arrList = new ArrayList() { "1", 1, true, 0.5,false, Math.PI };

            arrList.Add("saygin");
            arrList.Add(35);
            arrList.Add(true);
            arrList.Add(555.555d);

            //sort will throw exception
            arrList.Reverse();

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
        }

        public static void ListTest() {
            List<int> mylist = new List<int>() { 1, 2, 3 };

            mylist.Add(100);
            mylist.Add(200);
            mylist.Add(300);
            mylist.Add(400);
            mylist.Add(300);
            mylist.Add(200);
            mylist.Add(100);

            mylist.Remove(300);
            mylist.AddRange(new int[] { 555, 444, 333, 222, -999, 2, 3, 4, 5, 6, 7, 1546874, 123, 12, 312, 312, 31 });

            Console.WriteLine($"item count in mylist { mylist.Count()}");
            Console.WriteLine($"item capacity in mylist { mylist.Capacity}");

            Console.WriteLine("Printing the list");
            PrintMyListInOneLine(mylist);



            //mylist.Clear(); //this will clear the list
            Console.WriteLine("my first item in the list " + mylist.First());
            Console.WriteLine("my last item in the list " + mylist.Last());

            Console.WriteLine("the max value in my list is : " + mylist.Max());
            Console.WriteLine("the min value in my list is : " + mylist.Min());

            Console.WriteLine("index of 100 is " + mylist.IndexOf(100));

            mylist.Sort();
            Console.WriteLine("sorted list");
            PrintMyListInOneLine(mylist);

            Console.WriteLine($"added numbers inside the list {mylist.Sum()}");
        }

        public static void PrintMyList(List<int> list) {

            int i = 0;
            foreach (var item in list)
            {
                Console.WriteLine($"item[{i}] : {item}");
                i += 1;
            }

        }

        public static void PrintMyListInOneLine(List<int> list) {
           
            Console.Write("[ ");

            foreach (var item in list)
            {
                if (list.Last() == item)
                {
                    Console.Write($"{item} ]");
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write($"{item}, ");
                }
            }

        }

        public static void PolymorphismTest() {
            Person jose = new Brazilian();
            //cast to Brazilian
            //(jose as Brazilian).PlaySoccer();

            Person daniel = new Korean();
            //cast to Korean
            //(daniel as Korean).KickAss();


            Person siamak = new Persian();
            //cast to Persian
            //(siamak as Persian).RuleTheWorld();

           
            List<Person> perList = new List<Person>() {
                 jose,
                daniel,
                siamak
            };

            foreach (Person person in perList)
            {
                person.Eat();

                if (person is Brazilian)
                {
                    ((Brazilian)person).PlaySoccer();
                }
                if (person is Korean)
                {
                    ((Korean)person).KickAss();
                }
                if (person is Persian)
                {
                    ((Persian)person).RuleTheWorld();
                }

            }




        }

        public static void Backpacktest()
        {
            Backpack mybackpack = new Backpack();
            //material doesnt have the set method 
            //you can not set Material
            //mybackpack.Material = "fabric";
            mybackpack.Pocket = 5;
            mybackpack.Size = "medium";
            mybackpack.Weight = 5.5;
            mybackpack.Havewheels = false;
            mybackpack.Color = "redish brown";

            mybackpack.printTheObjectProperties();
        }

        public static void Cattest() {

            Cat cat1 = new Cat("bobby", "black and white", true, 47.2d, 100, 100, 8.5d);


            Console.WriteLine($"before jumping weight: {cat1.Weight}");
            cat1.jump();
            cat1.jump();
            cat1.jump();
            cat1.jump();
            cat1.jump();
            Console.WriteLine($"after jumping weight: {cat1.Weight}");

            Console.WriteLine($"before sleep energy: {cat1.Energy}");
            cat1.sleep();
            Console.WriteLine($"after sleep energy: {cat1.Energy}");

            //cat1.sleep();
            //cat1.sleep();
            cat1.jump();
            cat1.jump();
            cat1.jump();
            cat1.jump();
            cat1.jump();

            Console.WriteLine($"before eat energy: {cat1.Energy}");
            Console.WriteLine($"before eat hunger: {cat1.Hunger}");
            cat1.eat();
            Console.WriteLine($"after eat energy: {cat1.Energy}");
            Console.WriteLine($"after eat hunger: {cat1.Hunger}");


            cat1.sound();
            cat1.Hunger = 10;
            Console.WriteLine($"{cat1.Name} is hungry? {(cat1.isHungry() ? "YES" : "NO")}");

            Cat defaultCat = new Cat();

            Console.WriteLine(defaultCat.Energy);//?

            Cat testCat = new Cat("testcat", "blue");
            Console.WriteLine(testCat.Color);


            Cat deadCat = new Cat("zombie", "zombie grey", false, 45d, 500, 50, 26);
            Console.WriteLine(deadCat.Energy);
        }
    }
}
