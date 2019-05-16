using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //inherited in student and teacher class
        //base() will call the Person constructor
        public Person()
        {
            Name = "jane";
            LastName = "doe";
            Email = "unknown";
        }

        public virtual void Eat()
        {
            Console.WriteLine("I am a person and I eat something");
        }

        //you can override virtual methods 
        //this is optional
        //virtual methods must have a body {} or in other words implementation
        public virtual void Speak() {
            Console.WriteLine("Hello I am person");
        }

        //abstract methods can not have a body {} or in other words implementation
        //you can not create private classes
        public abstract void Sleep();

    }
}
