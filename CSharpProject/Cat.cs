using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Cat : ICreatures
    {
        //this is for Cat class and it can be access via the class name
        // ex: Cat.objectCount
        //its just an example and not implemented
        //every single constructor should increment the object count variable
        //Warning: use delegating constructors to avoid mistakes
        public static int objectCount = 0;
        public bool IsAlive { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public bool IsCute { get; set; }
        public double BodyLength { get; set; }
        public int Hunger { get; set; }
        public int Energy { get; set; }
        public double Weight { get; set; }

        /// <summary>
        /// default const will initialize the values
        /// Name = "unknown";
        /// Color = "white";
        /// IsCute = false;
        /// BodyLength = 45.0d;
        /// Energy = 50;
        /// Hunger = 50;
        /// Weight = 8.1d;
        /// </summary>
        public Cat()
        {
            //when you create a new Cat()
            //this code will run
            Name = "unknown";
            Color = "white";
            IsCute = false;
            BodyLength = 45.0d;
            Energy = 50;
            Hunger = 50;
            Weight = 8.1d;
        }

        //overloaded constructor
        public Cat(string name, string color, bool iscute, double bodyLength, int energy, int hunger, double weight) {

            Name = name;
            Color = color;
            IsCute = iscute;
            BodyLength = bodyLength;

            if (energy >= 0 && energy <= 100)
                {
                    Energy = energy;
                }
                else
                {
                    Energy = -1;
                }
            Hunger = hunger;
            Weight = weight;
        }

        //overloaded constructor
        //delegating the constructor
        /// <summary>
        /// IsCute = false;
        /// BodyLength = 1;
        /// Energy = 1;
        /// Hunger = 1;
        /// Weight = 1;
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Color"></param>
        public Cat(string Name, string Color) :
            this(Name, Color, false, 1, 1, 1, 1)
        {
        }

        public double Jump() {
            if (Energy >= 6)
            {
                Energy -= 5;
                Hunger -= 5;
                Weight -= 0.1;
                Console.WriteLine($"I jumped {BodyLength*6}cm.");
                return BodyLength * 6;
            }
            else {
                return BodyLength;
            }
        }

        public void Sleep() {
            if (Energy < 100)
            {
                Energy += 20;
                if (Energy > 100)
                {
                    Energy = 100;
                }
                Weight -= 0.1;
                Console.WriteLine("I am sleeping so good");
            }
            else {
                Console.WriteLine("I dont want to sleep. My energy is full");
            }
        }

        public void Eat() {
            if (Hunger < 100)
            {
                Console.WriteLine("I am eating cat food");
                if (Energy < 100)
                {
                    Energy += 10;
                    if (Energy > 100)
                    {
                        Energy = 100;
                    }
                }
                Weight += 0.2;
                Hunger += 10;
            }
            else {
                Console.WriteLine("I am full");
            }
        }

        public void Sound() {
            Console.WriteLine("meow");
            Energy -= 1;
            Hunger -= 1;
        }

        public bool Ishungry() {
            return Hunger < 50;
        }

        public void Move() {
            Console.WriteLine("I am cat I sleep I dont move");
        }

        public void Poo() {
            Console.WriteLine("I will dig the sand and do action");
        }

    }
}
