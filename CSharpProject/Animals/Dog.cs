using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Dog :  ISpecial
    {

        public bool IsAlive { get; set; }

        public void Swim() {
            Console.WriteLine("yeea I like water");
        }

        public void Move()
        {
            Console.WriteLine("I move as a dog");
        }

        public void Poo()
        {
            Console.WriteLine("I poo");

        }

    }
}
