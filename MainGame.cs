using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionar_4C_Kadlcik
{
    public partial class MainGame : Form
    {
        private MainMenu mainMenu;
        private List<string> easyQuestions = new List<string>()
        {
            "sdsdsd1?",
            "sdsdsd2?",
        };

        private List<string[]> easyAnswers = new List<string[]>()
        {
            new string[]{"a11","b21","c31","d41"},
            new string[]{"a12","b22","c32","d42"}
        };

        private List<int> easyCorrect = new List<int>()
        {
            0,1
        };

        private List<string> takenEasyQuestions = new List<string>();
        private List<string[]> takenEasyAnswers = new List<string[]>();
        public MainGame(MainMenu mM)
        {
            mainMenu = mM;
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void shop_Click(object sender, EventArgs e)
        {

        }
    }
}
