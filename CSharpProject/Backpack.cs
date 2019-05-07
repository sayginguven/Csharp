using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Backpack
    {
        //just get method 
        public string Material { get; }

        //just set method
        public int Pocket {
            set {
                Pocket = value;
            }
            //no get
        }
        //modified get
        public string Color {
            get{
                Color += "!";
                return Color;
            }
            set {
                Color = value;
            }

        }

        //auto get and set
        public string Size { get; set; }
        public double Weight { get; set; }
        public bool Havewheels { get; set;  }


        /// <summary>
        /// prints all object properties in a order
        /// </summary>
        public void printTheObjectProperties()
        {
            Console.WriteLine($" material : {Material} \n" +
                $"pocket size : \"private!\" \n" +
                $"color : {Color} \n" +
                $"size : {Size} \n" +
                $"weight : {Weight} \n" +
                $"haveWheels : {Havewheels} \n ");
        }


        //zip
        //carry
        //production date

    }
}
