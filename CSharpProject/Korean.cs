using System;
namespace CSharpProject
{
    public class Korean : Person
    {
        public override void Sleep() {
            Console.WriteLine("I sleep like a Korean");
        }

        public override void eat() {
            base.eat();
            Console.WriteLine("I am Korean and I eat bulgogi");
        }


    }
}
