using System;
using System.Collections.Generic;

namespace CSharpProject
{
    public class Rollerblade
    {
        public string Material { get; private set; } 
        public string Color { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public string Brand { get; private set; }
        public List<Wheels> Wheel { get; set; }

        public Rollerblade()
            : this("plastic", "white", 10, "race", "firefly" ,
                  new List<Wheels>() { new Wheels(), new Wheels(), new Wheels(), new Wheels() } )
        {

        }

        public Rollerblade(string material, string color, int size, 
                           string type, string brand, List<Wheels> wheel)
        {
            Material = material;
            Color = color;
            Size = size;
            Type = type;
            Brand = brand;
            Wheel = wheel;
        }

        public string Accelerate(string speed = "5 km/h") {
        
            foreach (var item in Wheel)
            {
                item.Bearing.Sound = true;
            }

            return speed;
        }

        public void DoMaintanceForBearings() {

            foreach (var item in Wheel)
            {
                item.Bearing.Sound = false;
            }

        }

        public void Brake() {
            Console.WriteLine("Rollerblade stopped");
        }
    }
}
