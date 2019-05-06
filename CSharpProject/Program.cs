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

            Backpack myBackpack = new Backpack();

            myBackpack.setMaterial("fabric");
            myBackpack.setPocket(5);
            myBackpack.setColor("black");
            myBackpack.setSize("large");
            myBackpack.setWeight(10.6);
            myBackpack.setHaveWheels(false);

            myBackpack.printTheObjectProperties();

            Backpack girlsBackpack = new Backpack();
            girlsBackpack.setMaterial("plastic");
            girlsBackpack.setPocket(2);
            girlsBackpack.setColor("pink");
            girlsBackpack.setSize("small");
            girlsBackpack.setWeight(3.6);
            girlsBackpack.setHaveWheels(true);

            girlsBackpack.printTheObjectProperties();

        }

    }
}
