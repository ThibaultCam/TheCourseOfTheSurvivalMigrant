namespace TheCurseOfTheSurvivalMigrant
{
    public class Answer
    {
        private string _action;
        private Enigma _next;
        private string _consequence;

        public string Action { get; set; }
        public Enigma NextEnigma { get; set; }
        public string Consequence { get; set; }

    }
}
