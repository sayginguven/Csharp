using System;
namespace CSharpProject
{
    public class Wheels<T>
    {

        public T Material { get; set; }
        public T Performance { get; set; }
        public Bearing<int, bool, string> Bearing { get; set; }

        public Wheels()
        {

        }

        public Wheels(T material, T performance, Bearing<int, bool, string> bearing) {
            Material = material;
            Performance = performance;
            Bearing = bearing;

        }




    }
}
