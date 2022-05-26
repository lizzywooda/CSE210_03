using System;
using System.Collections.Generic;

namespace CSE210_03.Game
{
    public class Director
    {
        public void StartGame()
        {
            Parachute parachute = new Parachute();
            Puzzle puzzle = new Puzzle();
            var word = puzzle.GetWord();
            parachute.DrawParachute();
        }
    }
}
