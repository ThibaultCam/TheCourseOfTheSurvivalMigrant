using System;

namespace TheCurseOfTheSurvivalMigrant.AnswerTypes
{
    public abstract class Answer
    {
        public string Action { get; set; }
        public Enigma NextEnigma { get; set; }
        public string Consequence { get; set; }
        
    }
}
