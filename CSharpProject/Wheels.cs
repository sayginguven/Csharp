using System;
namespace CSharpProject
{
    public class Wheels
    {

        public string Material { get; set; }
        public string Performance { get; set; }
        public Bearing Bearing { get; set; }

        public Wheels()
            :this("rubber", "amateur", new Bearing())
        {

        }

        public Wheels(string material, string performance, Bearing bearing) {
            Material = material;
            Performance = performance;
            Bearing = bearing;

        }




    }
}
