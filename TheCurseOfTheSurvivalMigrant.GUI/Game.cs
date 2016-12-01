using System;
using System.Windows.Forms;

namespace TheCurseOfTheSurvivalMigrant.GUI
{
    public partial class Game : UserControl
    {
        Controller _controller;
        public Game(Controller c)
        {
            InitializeComponent();
            _controller = c;
            string test = _controller.Form.Context.CurrentEnigma.Question;
            EnigmaLabel.Text = _controller.Form.Context.CurrentEnigma.Question;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            _controller.Form.ShowMenu();
        }
    }
}
