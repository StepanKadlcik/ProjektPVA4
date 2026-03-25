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
        private int iOtazky = 0;
        private int phase = 1;
        private Random r = new Random();
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
            next_Question();
        }

        private void next_Question()
        {
            switch (phase)
            {
                case 1:
                    if (easyQuestions.Count != 0)
                    {
                        iOtazky = r.Next(0, easyQuestions.Count);
                        question.Text = easyQuestions[iOtazky];
                        fill_Answer_Buttons(iOtazky);
                    }
                    else
                    {
                        iOtazky = 0;
                        phase++;
                        next_Question();
                        break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void fill_Answer_Buttons(int otazka)
        {
            answerA.Text = $"a) {easyAnswers[otazka][0]}";
            answerB.Text = $"b) {easyAnswers[otazka][1]}";
            answerC.Text = $"c) {easyAnswers[otazka][2]}";
            answerD.Text = $"d) {easyAnswers[otazka][3]}";
        }

        private void check_Answer(int index, int iOtazky, int phase)
        {
            switch (phase)
            {
                case 1:
                    if (easyAnswers[iOtazky][index] == easyAnswers[iOtazky][easyCorrect[iOtazky]])
                    {
                        takenEasyAnswers.Add(easyAnswers[iOtazky]);
                        takenEasyQuestions.Add(easyQuestions[iOtazky]);

                        easyAnswers.RemoveAt(iOtazky);
                        easyQuestions.RemoveAt(iOtazky);

                        easyCorrect.RemoveAt(iOtazky);

                        iOtazky = 0;
                        next_Question();
                    }
                    break;
                default:
                    break;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            GameShop gS= new GameShop();
            gS.Show();
        }

        private void answerA_Click(object sender, EventArgs e)
        {
            check_Answer(0, iOtazky, phase);
        }

        private void answerB_Click(object sender, EventArgs e)
        {
            check_Answer(1, iOtazky, phase);
        }

        private void answerC_Click(object sender, EventArgs e)
        {
            check_Answer(2, iOtazky, phase);
        }

        private void answerD_Click(object sender, EventArgs e)
        {
            check_Answer(3, iOtazky, phase);
        }
    }
}
