using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Milionar_4C_Kadlcik
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Opravdu chcete odejít?", "Ukončení hry", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            GetNameDialog getName = new GetNameDialog();
            getName.ShowDialog();
            if (getName.isOk)
            {
                string name = getName.Name;
                MainGame mG = new MainGame();
                mG.Show();
                this.Hide();
                MessageBox.Show(name);
            }
        }
    }
}
