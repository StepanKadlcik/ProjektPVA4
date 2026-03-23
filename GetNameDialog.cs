using System;
using System.Windows.Forms;

namespace Milionar_4C_Kadlcik
{
    public partial class GetNameDialog : Form
    {
        public string Name
        {
            get { return inputName.Text; }
            set { inputName.Text = value; }
        }

        public bool isOk = false;
        public GetNameDialog()
        {
            InitializeComponent();
        }

        private void GetNameDialog_Load(object sender, EventArgs e)
        {
            inputName.Text = "";
        }

        private void ok_Click(object sender, EventArgs e)
        {
            isOk = true;
            this.Hide();
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            Name = inputName.Text;
        }
    }
}
