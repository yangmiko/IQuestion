using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IQuestion.Business.Configs;
using IQuestion.Business.BusinessFacade;
using IQuestion.DataClass;
using Yangs.Accumulation.WindowsUI.WindowsForm;
using IQuestion.Business;

namespace IQuestion.MainUI
{
    public partial class frmNewQuestion : Form
    {
        public frmNewQuestion()
        {
            InitializeComponent();
        }

        private void frmNewQuestion_Load(object sender, EventArgs e)
        {
            string strMessage = String.Empty;
            if (!LoadLevels(out strMessage))
            {
                MessageBox.Show(strMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!LoadGenre(out strMessage))
            {
                MessageBox.Show(strMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtQuestionEN.Text = String.Empty;
            this.txtQuestionCN.Text = String.Empty;
            this.txtAnswerEN.Text = String.Empty;
            this.txtAnswerCN.Text = String.Empty;
            this.txtQuestionEN.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtQuestionEN.Text == String.Empty)
            {
                MessageBox.Show("Please input question in English.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (this.cboGenre.SelectedIndex < 0)
            {
                MessageBox.Show("Please select genre.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (this.cboLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Please select level.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string strMessage = String.Empty;
            T_QUESTION objQuestion = new T_QUESTION();
            objQuestion.QuestionID = Guid.NewGuid().ToString().Replace("-", String.Empty);
            objQuestion.QuestionEN = this.txtQuestionEN.Text;
            objQuestion.QuestionCN = this.txtQuestionCN.Text;
            objQuestion.AnswerEN = this.txtAnswerEN.Text;
            objQuestion.AnswerCN = this.txtAnswerCN.Text;
            objQuestion.GenreID = ((T_GENRE)this.cboGenre.SelectedItem).GENREID;
            objQuestion.Level = ((LevelDatum)this.cboLevel.SelectedItem).LevelValue;
            objQuestion.Valid = ValidFlags.VALID;
            QuestionDataFacade objQuestionDataFacade = new QuestionDataFacade();
            if (objQuestionDataFacade.NewAQuestion(objQuestion, ref strMessage))
            {
                this.txtQuestionEN.Text = String.Empty;
                this.txtQuestionCN.Text = String.Empty;
                this.txtAnswerEN.Text = String.Empty;
                this.txtAnswerCN.Text = String.Empty;
                this.txtQuestionEN.Focus();
            }
            else
            {
                MessageBox.Show(strMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool LoadLevels(out string argErrorMessage)
        {
            bool blnResult = false;
            argErrorMessage = String.Empty;
            try
            {
                LevelReader objLevelReader = new LevelReader();
                for (int intIndex = 0; intIndex < objLevelReader.Count; intIndex++)
                {
                    this.cboLevel.Items.Add(objLevelReader[intIndex]);
                }
                blnResult = true;
            }
            catch (Exception ex)
            {
                argErrorMessage = ex.Message;
            }
            return blnResult;
        }

        private bool LoadGenre(out string argErrorMessage)
        {
            argErrorMessage = String.Empty;
            GenreDataFacade objGenreDataFacade = new GenreDataFacade();
            List<T_GENRE> listGenres = new List<T_GENRE>();
            if (objGenreDataFacade.GetAllRenres(ref listGenres, ref argErrorMessage))
            {
                for (int intIndex = 0; intIndex < listGenres.Count; intIndex++)
                {
                    this.cboGenre.Items.Add(listGenres[intIndex]);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtQuestionCN_Enter(object sender, EventArgs e)
        {
            YangsTyping.SwitchTo(InputLanguages.INPUT_LANGUAGE_CHINESE);
        }

        private void txtAnswerCN_Enter(object sender, EventArgs e)
        {
            YangsTyping.SwitchTo(InputLanguages.INPUT_LANGUAGE_CHINESE);
        }
    }
}