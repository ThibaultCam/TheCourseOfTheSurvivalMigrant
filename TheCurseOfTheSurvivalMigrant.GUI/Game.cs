using System;
using System.Windows.Forms;

namespace TheCurseOfTheSurvivalMigrant.GUI
{
    public partial class Game : UserControl
    {
        Controller _controller;
        VerticalProgressBar _socialProgressBar;
        VerticalProgressBar _lifeProgressBar;
        VerticalProgressBar _moneyProgressBar;
        public Game(Controller c)
        {
            InitializeComponent();
            _controller = c;
            string test = _controller.Form.Context.CurrentEnigma.Question;
            EnigmaLabel.Text = _controller.Form.Context.CurrentEnigma.Question;
            CreateVerticalProgressBar();
        }

        public void CreateVerticalProgressBar()
        {
            _socialProgressBar = new VerticalProgressBar();
            panel1.Controls.Add(_socialProgressBar);
            _socialProgressBar.Location = new System.Drawing.Point(205, 3);
            _socialProgressBar.Size = new System.Drawing.Size(19, 72);
            _lifeProgressBar = new VerticalProgressBar();
            panel1.Controls.Add(_lifeProgressBar);
            _lifeProgressBar.Location = new System.Drawing.Point(125, 3);
            _lifeProgressBar.Size = new System.Drawing.Size(19, 72);
            _moneyProgressBar = new VerticalProgressBar();
            panel1.Controls.Add(_moneyProgressBar);
            _moneyProgressBar.Location = new System.Drawing.Point(45, 3);
            _moneyProgressBar.Size = new System.Drawing.Size(19, 72);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            _controller.Form.ShowMenu();
        }

        private void panelAnswer1_Click(object sender, EventArgs e)
        {
            
        }

        private void panelAnswer2_Click(object sender, EventArgs e)
        {

        }

        private void panelAnswer3_Click(object sender, EventArgs e)
        {

        }
    }
}
