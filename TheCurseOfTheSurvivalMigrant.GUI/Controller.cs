using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCurseOfTheSurvivalMigrant.GUI
{
    public class Controller
    {
        Form _f;
        Game _g;
        Menu _m;

        public Controller(Form f)
        {
            _f = f;
            _g = new Game(this);
            _m = new Menu(this);
        }

        public Form GetForm()
        {
            return _f;
        }

        public Game GetGame()
        {
            return _g;
        }

        public Menu GetMenu()
        {
            return _m;
        }
    }
}
