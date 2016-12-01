using System;

namespace TheCurseOfTheSurvivalMigrant.AnswerTypes
{
    public class AnswerRemoveFiveSocial : Answer
    {
        public static void ChangeState( Player player )
        {
            player.Social -= 5;
        }
    }
}
