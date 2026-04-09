using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionar_4C_Kadlcik
{
    public partial class MainGame : Form
    {
        private bool goodAnswer = false;
        private int iOtazky = 0;
        private int phase = 1;
        private Random r = new Random();
        private MainMenu mainMenu;
        private List<string> questionsBase = new List<string>()
        {
            "Kdo je aktuálním ředitelem OAKM?",
            "Jaké číslo má účebna nad jídelnou OAKM?",
            "Třetí planetou Sluneční soustavy je?",
            "Kolik obyvatel má aktuálně ČR?",
            "Který z těchto učitelů OAKM je matikář?",
            "Kolik je ve 4.C aktuálně studentů?",
            "Jak se jmenuje současný premiér ČR (2026)?",
            "Která z těchto vět je pravdivá?",
            "Která učebna OAKM není modernizovaná?",
            "V jakém století zemřel Karel IV.?",
            "Která z těchto postav opravdu existovala?",
            "Jeden z těchto cyklů v C# neexistuje, který?",
            "Který mobil používal prezident Miloš Zeman?",
            "Kolik otázek má hra Chcete Být Milionářem?",
            "Kdo z těchto osob má největší IQ?"
        };

        private List<string[]> answers = new List<string[]>()
        {
            new string[]{ "Petr Novotný", "Mojmír Šemnický", "Tomáš Valach", "Joe Biden" },
            new string[]{ "455", "363", "666", "550" },
            new string[]{ "Země", "Kepler-22b", "Mars", "Pluto" },
            new string[]{ "105 milionu", "45 tisíc", "10,9 milionu", "999 tisíc" },
            new string[]{ "Miloš Zeman", "Petr Pechanec", "Mojmír Šemnický", "Jolanda Lakatoš" },
            new string[]{ "12", "14", "16", "18" },
            new string[]{ "Andrej Babiš", "Tomáš Valach", "Miloš Zeman", "Petr Fiala" },
            new string[]{ "Pi je 3,12.", "Pi je 3,14.", "Pi je 8,23.", "Pi neexistuje." },
            new string[]{ "550", "314", "361", "353" },
            new string[]{ "14. století", "13. století", "12. století", "11. století" },
            new string[]{ "Jan Žižka z Trocnova", "Petr z Trocnova", "Jan Žižák z Trocnova", "Jan žižka pod Trocnovem"},
            new string[]{ "While", "Do while", "While do", "Foreach"},
            new string[]{ "Motorola", "Iphone", "Nokia 3310", "Aligátor"},
            new string[]{ "15", "11", "10", "25"},
            new string[]{ "Stephen Hokring", "William James Sidis", "Albert Epstein", "Adolf Hladík"},

        };

        private List<int> correct = new List<int>()
        {
            1,3,0,2,1,2,0,1,3,0,0,2,3,0,1
        };

        private List<string> takenQuestions = new List<string>();
        private List<string[]> takenAnswers = new List<string[]>();
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

            iOtazky = r.Next(0, questionsBase.Count);
            if (iOtazky !=14)
            {
                question.Text = questionsBase[iOtazky];
                fill_Answer_Buttons(iOtazky);
                phase++;
            }
            else
            {
                last_question();
            }
            

        }

        private void last_question()
        {
            MessageBox.Show("poslední otázka");
        }

        private void fill_Answer_Buttons(int otazka)
        {
            answerA.Text = $"a) {answers[otazka][0]}";
            answerB.Text = $"b) {answers[otazka][1]}";
            answerC.Text = $"c) {answers[otazka][2]}";
            answerD.Text = $"d) {answers[otazka][3]}";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            GameShop gS = new GameShop();
            gS.Show();
        }

        private async void answerQuestion(Button btn, int i)
        {
            btn.Enabled = false;

            bool isCorrect = (answers[iOtazky][i] == answers[iOtazky][correct[iOtazky]]);
            int answerNumber = 2;
            int countdown = 5;

            while (countdown > 0)
            {
                btn.BackColor = System.Drawing.Color.OrangeRed;
                timeLeft.Text = $"{countdown}";

                await Task.Delay(1000);
                countdown--;
            }

            if (isCorrect)
            {
                btn.BackColor = System.Drawing.Color.Green;
                MessageBox.Show($"{answerNumber}");
                switch (answerNumber)
                {
                    case 2:
                        q2.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 3:
                        q3.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 4:
                        q4.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 5:
                        q5.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 6:
                        q6.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 7:
                        q7.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 8:
                        q8.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 9:
                        q9.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 10:
                        q10.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 11:
                        q11.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 12:
                        q12.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 13:
                        q13.ForeColor = System.Drawing.Color.Orange;
                        answerNumber++;
                        break;
                    case 14:
                        q14.ForeColor = System.Drawing.Color.Orange;
                        break;
                    default:
                        break;

                }
            }
            else
            {
                btn.BackColor = System.Drawing.Color.Red;
            }

            await Task.Delay(1000);

            if (isCorrect)
            {
                takenAnswers.Add(answers[iOtazky]);
                takenQuestions.Add(questionsBase[iOtazky]);

                answers.RemoveAt(iOtazky);
                questionsBase.RemoveAt(iOtazky);
                correct.RemoveAt(iOtazky);

                next_Question();
            }

            btn.Enabled = true;
            btn.BackColor = System.Drawing.Color.Navy;
        }

        private void answerA_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            answerQuestion(btn, 0);
            btn.BackColor = System.Drawing.Color.Navy;
        }

        private void answerB_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            answerQuestion(btn, 1);
            btn.BackColor = System.Drawing.Color.Navy;
        }

        private void answerC_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            answerQuestion(btn, 2);
            btn.BackColor = System.Drawing.Color.Navy;
        }

        private void answerD_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            answerQuestion(btn, 3);
            btn.BackColor = System.Drawing.Color.Navy;
        }
    }
}
