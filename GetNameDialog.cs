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
    public partial class GetNameDialog : Form
    {
        public string Name
        {
            get { return inputName.Text; }
            set { inputName.Text = value; }
        }
        public GetNameDialog()
        {
            InitializeComponent();
        }

        private void GetNameDialog_Load(object sender, EventArgs e)
        {
            
        }
    }
}
