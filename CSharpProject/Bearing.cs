using System;
namespace CSharpProject
{
    public class Bearing
    {
        public int Ball { get; set; }
        public bool Sound { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }

        public Bearing()
            :this(10, false,"roller bearing","metal")
        {

        }

        public Bearing(int ball, bool sound, string type, string material)
        {
            Ball = ball;
            Sound = sound;
            Type = type;
            Material = material;
        }

        public string NeedsLubricate() {

           return Sound ? "please lubricate it!" : "everything is good, no lubrication is required.";
            }


    }
}
