using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace CSharpProject
{
    class Program
    {

        static void Main(string[] args){

            //Cat cat1 = new Cat();
            //string JSONcat = JsonConvert.SerializeObject(cat1);
            //Console.WriteLine(JSONcat);


            WebClient LondonObj = new WebClient();
            string result = LondonObj.DownloadString(
                "http://api.openweathermap.org/data/2.5/weather?q=Astana &appid=5a14851e7a7b812c16d430b322cf27e3");
            dynamic csharpObj = JsonConvert.DeserializeObject<dynamic>(result);

            //Console.WriteLine(csharpObj["name"]);


            Console.WriteLine($"Location : {csharpObj["name"]} \n" +
            	$"The weather is : {csharpObj["weather"][0]["description"]}\n"+
                $"The max temp is : {csharpObj["main"]["temp_max"] - 273.15} C\n"+
                $"The min temp is : {csharpObj["main"]["temp_min"] - 273.15} C\n"
           );


            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
           dtDateTime = dtDateTime.AddSeconds(1558442014).ToLocalTime();


            Console.WriteLine("Sunrise : " + dtDateTime);

            dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(1558496476).ToLocalTime();

            Console.WriteLine("Sunset : " + dtDateTime);


        }




        #region later check

        public class Human
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        public static void later() {

            Rollerblade<int, string> r1 = new Rollerblade<int, string>(
                    "plastic",
                    "blue",
                    10,
                    "intermediate",
                    "noname",
                  new List<Wheels<string>>() {
                new Wheels<string>("rubber","mid",new Bearing<int,bool, string>(15,false, "speed","cupper")),
                new Wheels<string>("rubber","mid",new Bearing<int,bool, string>(15,false, "speed","cupper")),
                new Wheels<string>("rubber","mid",new Bearing<int,bool, string>(15,false, "speed","cupper"))
                    }
                );


            string str = JsonConvert.SerializeObject(r1);

            Console.WriteLine(str);

            Console.WriteLine("\n\n\n\n");

            WebClient client = new WebClient();
            string webstr = client.DownloadString("http://www.json-generator.com/api/json/get/ckNtUCMGmq?indent=2");

            Human Michael = JsonConvert.DeserializeObject<Human>(webstr);

            Console.WriteLine(Michael.Name);
            Console.WriteLine(Michael.LastName);
            Console.WriteLine(Michael.Email);
        }
        #endregion


        public static void Cuptest() {
            Console.WriteLine("\n\n");

            Cups<string, int> mycup = new Cups
                <string, int>("black", 5, 2);
            mycup.PrintTheCup();
        }

        public static void PrintMessage<T>(T msg) {
            Console.WriteLine(msg);
        }

        public static double Add<T>(T a, T b) {
            return Convert.ToDouble(a) + Convert.ToDouble(b);
        }

        public static void PrintSpecial<T1,T2>(T1 count, T2 msg) {

            for (int i = 0; i < Convert.ToInt32(count); i++)
            {
                Console.WriteLine((i+1).ToString() + " - " + msg.ToString());
            }

        }




        #region my main function with some tests

        public static void QueueAndStackTest() {

            Queue<Rollerblade<int, string>> myQueue = new Queue<Rollerblade<int, string>>();
            Stack<Rollerblade<int, string>> myStack = new Stack<Rollerblade<int, string>>();


            Rollerblade<int, string> r1 = new Rollerblade<int, string>(
                "plastic",
                "blue",
                10,
                "intermediate",
                "noname",
              new List<Wheels<string>>() {
                new Wheels<string>("rubber","mid",new Bearing<int,bool, string>(15,false, "speed","cupper")),
                new Wheels<string>("rubber","mid",new Bearing<int,bool, string>(15,false, "speed","cupper")),
                new Wheels<string>("rubber","mid",new Bearing<int,bool, string>(15,false, "speed","cupper"))
                }
            );


            //do not use this
            Rollerblade<int, string> willCreateNullException = new Rollerblade<int, string>();


            Rollerblade<int, string>  r2 = new Rollerblade<int, string>(
                "jelly plastic",
                "black",
                12,
                "advanced",
                "noname",
              new List<Wheels<string>>() {
                new Wheels<string>("composite","high",new Bearing<int,bool, string>(12,false, "race","aluminium - carbon")),
                new Wheels<string>("composite","high",new Bearing<int,bool, string>(12,false, "race","aluminium - carbon")),
                new Wheels<string>("composite","high",new Bearing<int,bool, string>(12,false, "race","aluminium - carbon"))
                }
            );

            Rollerblade<int, string> r3 = new Rollerblade<int, string>(
                "jelly plastic",
                "black",
                12,
                "advanced",
                "noname",
              new List<Wheels<string>>() {
                new Wheels<string>("plastic","low",new Bearing<int,bool, string>(10,false, "speed","steel")),
                new Wheels<string>("plastic","low",new Bearing<int,bool, string>(10,false, "speed","steel")),
                new Wheels<string>("plastic","low",new Bearing<int,bool, string>(10,false, "speed","steel"))
                }
            );
            Rollerblade<int, string> r4 = new Rollerblade<int, string>(
                "jelly plastic",
                "black",
                12,
                "advanced",
                "noname",
              new List<Wheels<string>>() {
                new Wheels<string>("rubber","high",new Bearing<int,bool, string>(9,false, "race","aluminium")),
                new Wheels<string>("rubber","high",new Bearing<int,bool, string>(9,false, "race","aluminium")),
                new Wheels<string>("rubber","high",new Bearing<int,bool, string>(9,false, "race","aluminium"))
                }
            );

            myQueue.Enqueue(r1);
            myQueue.Enqueue(r2);
            myQueue.Enqueue(r3);
            myQueue.Enqueue(r4);
            myQueue.Dequeue();

            Console.WriteLine("how many objects I have in myQueue " + myQueue.Count);
            Console.WriteLine(myQueue.Peek().Wheel[0].Bearing.Material);

            myStack.Push(r1);
            myStack.Push(r2);
            myStack.Push(r3);
            myStack.Push(r4);
            myStack.Pop();

            Console.WriteLine("how many objects I have in myStack " + myStack.Count);

            Console.WriteLine(myStack.Peek().Wheel[0].Bearing.Material);
        }

        public static void RollerbladeTest() {

            Rollerblade<int, string> myRollerblade = new Rollerblade<int, string>(
                "plastic",
                "blue",
                10,
                "intermediate",
                "noname",
              new List<Wheels<string>>() {
                new Wheels<string>("rubber","mid",new Bearing<int,bool, string>(15,false, "speed","cupper")),
                new Wheels<string>("rubber","mid",new Bearing<int,bool, string>(15,false, "speed","cupper")),
                new Wheels<string>("rubber","mid",new Bearing<int,bool, string>(15,false, "speed","cupper"))
                }
            );


            Console.WriteLine("my rollerblade color is : " + myRollerblade.Color); // white
            List<Wheels<string>> wheelsInMyRollerBlade = myRollerblade.Wheel;

            Console.WriteLine("\n");

            Console.WriteLine("my rollerblade has " + wheelsInMyRollerBlade.Count + " wheels");
            Console.WriteLine("my rollerblade's brand is " + myRollerblade.Brand);
            Console.WriteLine("my rollerblade's material is " + myRollerblade.Material);
            Console.WriteLine("my rollerblade's color is " + myRollerblade.Color);

            myRollerblade.Color = "purple";

            Console.WriteLine("\n");


            Console.WriteLine("my rollerblade's color is " + myRollerblade.Color);

            //foreach (var item in wheelsInMyRollerBlade)
            //{
            //    Console.WriteLine( item.Material  );
            //    Console.WriteLine( item.Performance );
            //}

            Console.WriteLine("wheelsInMyRollerBlade's first wheel bearing type is " +
                wheelsInMyRollerBlade[0].Bearing.Type);

            Console.WriteLine("does my wheelsInMyRollerBlade need maintanance? : " +
                wheelsInMyRollerBlade[0].Bearing.NeedsLubricate());

            Console.WriteLine("the speed of my rollerblade is " + myRollerblade.Accelerate("10 km/h"));

            Console.WriteLine("\n");


            Console.WriteLine("does my wheelsInMyRollerBlade need maintanance? : ");

            int count = 1;
            foreach (var item in myRollerblade.Wheel)
            {

                Console.WriteLine("number " + count + " " + item.Bearing.NeedsLubricate());
                count += 1;
            }

            myRollerblade.DoMaintanceForBearings();

            Console.WriteLine("\n");

            Console.WriteLine("after maintanance : ");
            count = 1;
            foreach (var item in myRollerblade.Wheel)
            {
                Console.WriteLine("number " + count + " " + item.Bearing.NeedsLubricate());
                count += 1;
            }

            myRollerblade.Brake();
        }

        public static void DictionaryTest() {
            Dictionary<string, string> dict = new Dictionary<string, string>() {
                {"unique key","this is a value associated with unique key"}
            };

            dict.Add("business", "an occupation, profession, or trade");

            Console.WriteLine(dict["business"]);
            Console.WriteLine(dict["unique key"]);

            dict.Add("one", "first number");
            dict.Remove("one");


            Dictionary<int, string> indexDict = new Dictionary<int, string>() {
                {0, "zero"},
                {1, "one"},
                {100, "one hundred"}
            };

            Console.WriteLine(indexDict[0]);

            foreach (var item in indexDict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            KeyValuePair<int, string> searchThis = new KeyValuePair<int, string>(1, "one");

            Console.WriteLine("seach 1 - one, result : " + indexDict.Contains(searchThis));
            Console.WriteLine("search 2 - two, result : " + indexDict.Contains(new KeyValuePair<int, string>(2, "two")));


            Console.WriteLine("key 1 ? : " + indexDict.ContainsKey(1));
            Console.WriteLine("key 2 ? : " + indexDict.ContainsKey(2));


            Console.WriteLine("value one ? : " + indexDict.ContainsValue("one"));
            Console.WriteLine("value two ? : " + indexDict.ContainsValue("two"));
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

            mybackpack.PrintTheObjectProperties();
        }

        public static void Cattest() {

            Cat cat1 = new Cat("bobby", "black and white", true, 47.2d, 100, 100, 8.5d);


            Console.WriteLine($"before jumping weight: {cat1.Weight}");
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            Console.WriteLine($"after jumping weight: {cat1.Weight}");

            Console.WriteLine($"before sleep energy: {cat1.Energy}");
            cat1.Sleep();
            Console.WriteLine($"after sleep energy: {cat1.Energy}");

            //cat1.sleep();
            //cat1.sleep();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();

            Console.WriteLine($"before eat energy: {cat1.Energy}");
            Console.WriteLine($"before eat hunger: {cat1.Hunger}");
            cat1.Eat();
            Console.WriteLine($"after eat energy: {cat1.Energy}");
            Console.WriteLine($"after eat hunger: {cat1.Hunger}");


            cat1.Sound();
            cat1.Hunger = 10;
            Console.WriteLine($"{cat1.Name} is hungry? {(cat1.Ishungry() ? "YES" : "NO")}");

            Cat defaultCat = new Cat();

            Console.WriteLine(defaultCat.Energy);//?

            Cat testCat = new Cat("testcat", "blue");
            Console.WriteLine(testCat.Color);


            Cat deadCat = new Cat("zombie", "zombie grey", false, 45d, 500, 50, 26);
            Console.WriteLine(deadCat.Energy);
        }

        #endregion
    }
}