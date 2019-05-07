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
            //Variables.body();
            //OtherVariables.body();
            //MathLibrary.body();
            //ConvertingTypes.body();
            //ConditionalStatements.body();
            //Loops.body();
            //ArraysLibrary.body();
            //Functions.body();
            //Functions.game();

        }


        public static void backpacktest() {
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

        public static void cattest() {

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
