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

        public override string Address
        {

            get => throw new Exception("ops address is not set for teacher");
            set => throw new Exception();

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

        public override void Speak()  
        {
            base.Speak();
            Console.WriteLine("I am a Teacher");
        }
        
    }
}
