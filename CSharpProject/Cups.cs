using System;
namespace CSharpProject
{
    public class Cups<T1,T2>
    {

        public T1 Color { get; set; }
        public T2 Height { get; set; }
        public T2 Weight { get; set; }

        public Cups()
        {

        }

        public Cups(T1 color, T2 height, T2 weight) {
            Color = color;
            Height = height;
            Weight = weight;
        }

        public void PrintTheCup() {
            Console.WriteLine($"Color is {Color.ToString()}\u000a" +
            	              $"Heigth is {Height.ToString()}\u000a" +
            		          $"Weight is {Weight.ToString()}\u000a");
        }

    }
}
