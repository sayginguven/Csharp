using System;
namespace CSharpProject
{
    public class Persian : Person
    {
        public override void Sleep()
        {
            Console.WriteLine("I sleep like a Persian");
        }

        public override void eat()
        {
            base.eat();
            Console.WriteLine("I am Persian and I eat kebab");
        }


    }
}
