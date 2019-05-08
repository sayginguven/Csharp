using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{

    class Teacher : Person
    {
       

        public string Expertise { get; set; }

        public Teacher() : base()
        {
            Expertise = "kung fu";
        }

        public Teacher(string Name, string LastName, 
            string Email, string Expertise)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
            this.Expertise = Expertise;
        }

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
