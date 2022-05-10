using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak
{
    public partial class Menu : Form
    {

        Game game = new Game();

        public Menu()
        {
            InitializeComponent();
        }

        private void btNGame_Click(object sender, EventArgs e)
        {
            game.ShowDialog();
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            game.ShowDialog();
        }

        private void btParam_Click(object sender, EventArgs e)
        {
            FParam fParam = new FParam();
            fParam.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            RuleGame ruleGame = new RuleGame();
            ruleGame.ShowDialog();
            
        }
    }
}
