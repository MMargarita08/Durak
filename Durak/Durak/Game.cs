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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы действительно хотите выйти?", "Сообщение", MessageBoxButtons.YesNo);
            
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        
    }
}
