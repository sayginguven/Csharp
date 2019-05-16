using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    interface ICreatures
    {
        bool IsAlive { get; set; }
        void Move();
        void Poo();
    }
}
