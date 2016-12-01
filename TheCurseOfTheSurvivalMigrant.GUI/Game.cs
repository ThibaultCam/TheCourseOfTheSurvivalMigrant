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
    public partial class Game : UserControl
    {
        Controller _c;
        public Game(Controller c)
        {
            _c = c;
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            _c.GetForm().ShowMenu();
        }
    }
}
