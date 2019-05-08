using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{

    class Teacher : Person
    {
        public string expertise { get; set; }

        public override void Sleep()
        {
            Console.WriteLine("zzz");
        }

        public override void speak()  
        {
            base.speak();
            Console.WriteLine("I am a Teacher");
        }
        
    }
}
