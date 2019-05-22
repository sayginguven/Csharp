using System;
namespace CSharpProject
{
    public class Korean : Person
    {
        public override string Address
        {

            get => throw new NotImplementedException();
            set => throw new NotImplementedException();

        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I am Korean and I eat bulgogi");
        }

        public void KickAss()
        {
            Console.WriteLine("I know taekwondo, don't mess with me");
        }

        public override void Sleep() {
            Console.WriteLine("sleep like a korean");
        }


    }
}
