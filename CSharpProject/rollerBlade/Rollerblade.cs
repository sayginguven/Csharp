using System;
using System.Collections.Generic;

namespace CSharpProject
{
    public class Rollerblade<T1,T3>
    {
        public T3 Material { get; private set; } 
        public T3 Color { get; set; }
        public T1 Size { get; set; }
        public T3 Type { get; set; }
        public T3 Brand { get; private set; }
        public List<Wheels<string>> Wheel { get; set; }

        public Rollerblade()
        {

        }

        public Rollerblade(T3 material, T3 color, T1 size, 
                           T3 type, T3 brand, List<Wheels<string>> wheel)
        {
            Material = material;
            Color = color;
            Size = size;
            Type = type;
            Brand = brand;
            Wheel = wheel;
        }

        public string Accelerate(T3 speed ) {
        
            foreach (var item in Wheel)
            {
                item.Bearing.Sound = true;
            }

            return speed.ToString();
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
