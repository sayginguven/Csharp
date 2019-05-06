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

            Backpack mybackpack = new Backpack();
            //material doesnt have the set method 
            //you can not set Material
            //mybackpack.Material = "fabric";
            mybackpack.Pocket = 5;
            mybackpack.Size = "medium";
            mybackpack.Weight = 5.5;
            mybackpack.Havewheels = false;
            mybackpack.Color = "redish brown";

           


        }

    }
}
