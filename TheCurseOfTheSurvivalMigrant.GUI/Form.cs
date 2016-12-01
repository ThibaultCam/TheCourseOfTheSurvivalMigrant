namespace TheCurseOfTheSurvivalMigrant.GUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        Controller _controller;
        GameContext _context;

        public Form()
        {
            InitializeComponent();
            _context = new GameContext();
            _controller = new Controller(this);
            ShowMenu();
        }

        public GameContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public void QuitGame()
        {
            Close();
        }

        public void StartGame()
        {
            _controller.Game.Show();
            _controller.Menu.Hide();
        }

        public void ShowMenu()
        {
            _controller.Game.Hide();
            _controller.Menu.Show();
        }
    }
}
