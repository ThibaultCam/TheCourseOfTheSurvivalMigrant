namespace TheCurseOfTheSurvivalMigrant.GUI
{
    public class Controller
    {
        Form _form;
        Game _game;
        Menu _menu;

        public Controller(Form f)
        {
            _form = f;
            _game = new Game(this);
            _menu = new Menu(this);
            _form.Controls.Add( _game );
            _form.Controls.Add( _menu );
        }
        public Form Form
        {
            get { return _form; }
        }

        public Game Game
        {
            get { return _game; }
        }

        public Menu Menu
        {
            get { return _menu; }
        }
    }
}
