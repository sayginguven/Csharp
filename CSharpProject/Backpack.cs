using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Backpack
    {
        public string Material { get; }
        public int Pocket { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Weight { get; set; }
        public bool Havewheels { get; set;  }


        /// <summary>
        /// prints all object properties in a order
        /// </summary>
        public void PrintTheObjectProperties()
        {
            Console.WriteLine($"material : {Material} \n" +
                $"pocket size : \"private!\" \n" +
                $"color : {Color} \n" +
                $"size : {Size} \n" +
                $"weight : {Weight} \n" +
                $"haveWheels : {Havewheels} \n ");
        }

    }
}
