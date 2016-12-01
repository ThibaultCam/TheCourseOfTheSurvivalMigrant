using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCurseOfTheSurvivalMigrant.GUI
{
    public partial class Menu : UserControl
    {
        Controller _controller;
        Form _form;
        public Menu(Controller c)
        {
            _controller = c;
            _form = _controller.Form;
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _form.StartGame();
        }

        private void quitterButton_Click(object sender, EventArgs e)
        {
            _form.QuitGame();
        }
    }
}
