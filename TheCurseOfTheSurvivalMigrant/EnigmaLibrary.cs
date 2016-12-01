using TheCurseOfTheSurvivalMigrant.AnswerTypes;

namespace TheCurseOfTheSurvivalMigrant
{
    public static class EnigmaLibrary
    {
        public static Enigma StarterEnigma = new Enigma
        {
            Question = "You just passed the border of your country. What do you do ?",
            Answers =
            {
                new AnswerRemoveFiveSocial
                {
                    Action = "You ask the nearest border gard where you are exactly, just to be sure.",
                    NextEnigma = StarterEnigma,
                    Consequence = "You are put in custody and lose 5 social points."
                },
                new AnswerRemoveFiveSocial
                {
                    Action = "You ask the nearest border gard where you are exactly, just to be sure.",
                    NextEnigma = StarterEnigma,
                    Consequence = "You are put in custody and lose 5 social points."
                },
                new AnswerRemoveFiveSocial
                {
                    Action = "You ask the nearest border gard where you are exactly, just to be sure.",
                    NextEnigma = StarterEnigma,
                    Consequence = "You are put in custody and lose 5 social points."
                }
            }
        };
    }
}
