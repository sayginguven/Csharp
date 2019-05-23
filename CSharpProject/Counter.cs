using System;
namespace CSharpProject
{
    public class Counter
    {

        public void Count1()
        {

            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Count 1 " + i);
                }
            }

        }

        public void Count2()
        {

            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Count 2 " + i);
                }
            }

        }

        public void Count3()
        {

            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Count 3 " + i);
                }
            }

        }
    }
}
