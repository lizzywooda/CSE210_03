using System;
using System.Collections.Generic;
namespace CSE210_03.Game
{
    public class Parachute
    {
        public List<string> parachute = new List<string>();
        public Parachute()
        {
            this.parachute.Add(" ___");
            this.parachute.Add("/___\\");
            this.parachute.Add("\\   /");
            this.parachute.Add(" \\ /");
            this.parachute.Add("  o");
            this.parachute.Add(" /|\\");
            this.parachute.Add(" / \\");
        }    
        
        public void DrawParachute()
        {
            foreach (var i in parachute)
            {
                Console.WriteLine(i);
            } 
        }

    }
}
