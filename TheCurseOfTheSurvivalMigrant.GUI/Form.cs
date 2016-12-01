using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCurseOfTheSurvivalMigrant.GUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        Controller ct;
        public Form()
        {
            InitializeComponent();
            ct = new Controller(this);
            Controls.Add(ct.GetGame());
            Controls.Add(ct.GetMenu());
            ShowMenu();
        }

        public void QuitGame()
        {
            Close();
        }

        public void StartGame()
        {
            ct.GetGame().Show();
            ct.GetMenu().Hide();
        }

        public void ShowMenu()
        {
            ct.GetGame().Hide();
            ct.GetMenu().Show();
        }
    }
}
