using System;
namespace CSharpProject
{
    public class Brazilian : Person
    {
        public override string Address
        {

            get => throw new NotImplementedException();
            set => throw new NotImplementedException();

        }


        public override void Sleep()
        {
            Console.WriteLine("I am sleeping like a brazilian");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I am a Brazilian and I eat feijoada");
        }

        public void PlaySoccer()
        {
            Console.WriteLine("I am playing soccer like pro");
        }

    }
}
