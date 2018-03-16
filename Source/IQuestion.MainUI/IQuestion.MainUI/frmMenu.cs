using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQuestion.MainUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            frmNewQuestion objNewQuestionForm = new frmNewQuestion();
            objNewQuestionForm.ShowDialog();
        }
    }
}
