namespace TheCurseOfTheSurvivalMigrant
{
    public class Player
    {
        private string _name;
        private int _money;
        private int _social;
        private int _health;

        public Player( string name )
        {
            _name = name;
            _health = 100;
            _money = 0;
            _social = 0;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
        public int Money
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value;
            }
        }
        public int Social
        {
            get
            {
                return _social;
            }
            set
            {
                _social = value;
            }
        }

    }
}
