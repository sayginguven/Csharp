using System;
namespace CSharpProject
{
    public class Brazilian : Person
    {

        public override void Sleep()
        {
            Console.WriteLine("I am sleeping like a brazilian");
        }

        public override void eat()
        {
            base.eat();
            Console.WriteLine("I am a Brazilian and I eat feijoada");
        }

    }
}
