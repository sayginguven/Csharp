using System;
namespace CSharpProject
{
    public class Persian : Person
    {
        public override string Address
        {

            get => throw new NotImplementedException();
            set => throw new NotImplementedException();

        }

        public override void Sleep()
        {
            Console.WriteLine("I sleep like a Persian");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I am Persian and I eat kebab");
        }

        public void RuleTheWorld()
        {
            Console.WriteLine("We are strong hahahaha");
        }


    }
}
