using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Student : Person
    {
        public Student()
        {
            Name = "";
        }

        public string program { set; get; }

        public override void Sleep()
        {
            Console.WriteLine("zzz zzz hrrr zzz");
        }

        public override void speak()
        {
            base.speak();
            Console.WriteLine("I am a Student");
        }
    }
}
