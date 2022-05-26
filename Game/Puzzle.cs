using System;
using System.Collections.Generic;

namespace CSE210_03.Game
{
    public class Puzzle
    {
        
        public List<string> _words = new List<string>();

        
        public Puzzle()
        {
            this._words.Add("Frog");
            this._words.Add("Cow");
            this._words.Add("Horse");
            this._words.Add("Dog");
            this._words.Add("Pet");
            this._words.Add("Lizard");
            this._words.Add("Fly");
            this._words.Add("Farm");
            this._words.Add("Pig");
            this._words.Add("Chicken");
            this._words.Add("Turkey");
        }

        public string GetWord()
        {
            Random random = new Random();
            int randomNumber = random.Next(this._words.Count);
            return this._words[randomNumber];
        }
    }
}
