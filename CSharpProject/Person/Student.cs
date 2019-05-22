using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Student : Person
    {

        public string Program { set; get; }

        public override string Address { 
        
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
       
        }  

        public Student():base()
        {
            Program = "n/a";
        }

        public Student(string Name, string LastName, string Email, string Program)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
        }

        public override void Sleep()
        {
            Console.WriteLine("zzz zzz hrrr zzz");
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("I am a Student");
        }

    }
}
