using System;
using System.Collections.Generic;
namespace CSharpProject
{

    public class Speed { 
    
        public int WalkSpeed { get; set; }
        public int RunSpeed { get; set; }
    }

    public class Status {

        public int Strenght { get; set; }
        public int Agility { get; set; }
        public Speed Speed {get; set;}
    }

    public class Hero
    {
        //properties
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Mana { get; set; }

        //?? for weapons
        public List<string> Weapons { get; set; }
        public Status Status { get; set; }

        public void IntroduceYourself() {

            Console.WriteLine("my name " + this.Name);
            Console.WriteLine("my health is : " + this.Hp);
            Console.WriteLine($"my weapons are : ");
            for (int i = 0; i < Weapons.Count; i++)
            {
                Console.WriteLine("  " + (i+1) + ". " + this.Weapons[i] + " ");
            }



            Console.WriteLine("my strenght " + this.Status.Strenght);
            Console.WriteLine("my agility " + this.Status.Agility);
            Console.WriteLine("my running speed " + this.Status.Speed.RunSpeed);
            Console.WriteLine("my walking speed " + this.Status.Speed.WalkSpeed);


        }

    }
}
