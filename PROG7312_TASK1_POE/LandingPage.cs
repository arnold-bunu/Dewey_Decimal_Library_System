using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_TASK1_POE
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
              
        private void btnReplace_Click_1(object sender, EventArgs e)
        {
            ReplaceBooks replaceBooks = new ReplaceBooks();
            replaceBooks.Show();
            this.Hide();
        }
    }
}
