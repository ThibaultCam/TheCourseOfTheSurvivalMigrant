using System.Collections.Generic;
using TheCurseOfTheSurvivalMigrant.AnswerTypes;

namespace TheCurseOfTheSurvivalMigrant.GUI
{
    public class GameContext
    {
        private Player _player;
        private Enigma _currentEnigma;
        
        public GameContext()
        {
            _player = new Player("Fx");
            Enigma enigma = new Enigma();
            enigma.Question = "You just passed the border of your country. What do you do ?";
            Answer answer1 = new AnswerRemoveFiveSocial();
            answer1.Action = "You ask the nearest border gard where you are exactly, just to be sure.";
            answer1.Consequence = "You are put in custody and lose 5 social points.";
            enigma.Answers = new List<Answer>();
            enigma.Answers.Add( answer1 );

            _currentEnigma = enigma;
        }
        public Player Player { get; set; }
        public Enigma CurrentEnigma
        {
            get { return _currentEnigma; }
            set { _currentEnigma = value; }
        }
    }
}
