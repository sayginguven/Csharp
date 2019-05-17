using System;
namespace CSharpProject
{
    public class Bearing<T1,T2,T3>
    {
        public T1 Ball { get; set; }
        public T2 Sound { get; set; }
        public T3 Type { get; set; }
        public T3 Material { get; set; }

        public Bearing()
            //:this(10, false,"roller bearing","copper")
        {

        }

        public Bearing(T1 ball, T2 sound, T3 type, T3 material)
        {
            Ball = ball;
            Sound = sound;
            Type = type;
            Material = material;
        }

        public string NeedsLubricate() {

           return Convert.ToBoolean(Sound) ? "please lubricate it!" : "everything is good, no lubrication is required.";
            }


    }
}
