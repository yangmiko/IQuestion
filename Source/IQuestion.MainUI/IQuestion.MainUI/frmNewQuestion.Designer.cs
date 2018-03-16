namespace IQuestion.MainUI
{
    partial class frmNewQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.layoutInput = new System.Windows.Forms.TableLayoutPanel();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtAnswerCN = new System.Windows.Forms.TextBox();
            this.txtAnswerEN = new System.Windows.Forms.TextBox();
            this.lblAnswerCN = new System.Windows.Forms.Label();
            this.lblAnswerEN = new System.Windows.Forms.Label();
            this.txtQuestionCN = new System.Windows.Forms.TextBox();
            this.lblQuestionCN = new System.Windows.Forms.Label();
            this.lblQuestionEN = new System.Windows.Forms.Label();
            this.txtQuestionEN = new System.Windows.Forms.TextBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.layoutMain.SuspendLayout();
            this.layoutInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 6;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.Controls.Add(this.layoutInput, 1, 1);
            this.layoutMain.Controls.Add(this.btnClear, 2, 2);
            this.layoutMain.Controls.Add(this.btnSave, 3, 2);
            this.layoutMain.Controls.Add(this.btnExit, 4, 2);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 4;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.Size = new System.Drawing.Size(1225, 582);
            this.layoutMain.TabIndex = 0;
            // 
            // layoutInput
            // 
            this.layoutInput.ColumnCount = 2;
            this.layoutMain.SetColumnSpan(this.layoutInput, 4);
            this.layoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutInput.Controls.Add(this.cboLevel, 1, 5);
            this.layoutInput.Controls.Add(this.lblLevel, 1, 4);
            this.layoutInput.Controls.Add(this.lblGenre, 0, 4);
            this.layoutInput.Controls.Add(this.txtAnswerCN, 1, 3);
            this.layoutInput.Controls.Add(this.txtAnswerEN, 0, 3);
            this.layoutInput.Controls.Add(this.lblAnswerCN, 1, 2);
            this.layoutInput.Controls.Add(this.lblAnswerEN, 0, 2);
            this.layoutInput.Controls.Add(this.txtQuestionCN, 1, 1);
            this.layoutInput.Controls.Add(this.lblQuestionCN, 1, 0);
            this.layoutInput.Controls.Add(this.lblQuestionEN, 0, 0);
            this.layoutInput.Controls.Add(this.txtQuestionEN, 0, 1);
            this.layoutInput.Controls.Add(this.cboGenre, 0, 5);
            this.layoutInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutInput.Location = new System.Drawing.Point(23, 23);
            this.layoutInput.Name = "layoutInput";
            this.layoutInput.RowCount = 6;
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutInput.Size = new System.Drawing.Size(1179, 496);
            this.layoutInput.TabIndex = 0;
            // 
            // cboLevel
            // 
            this.cboLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Location = new System.Drawing.Point(592, 469);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(584, 24);
            this.cboLevel.TabIndex = 11;
            // 
            // lblLevel
            // 
            this.lblLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLevel.Location = new System.Drawing.Point(592, 438);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(584, 28);
            this.lblLevel.TabIndex = 9;
            this.lblLevel.Text = "Level";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenre
            // 
            this.lblGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGenre.Location = new System.Drawing.Point(3, 438);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(583, 28);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnswerCN
            // 
            this.txtAnswerCN.AcceptsReturn = true;
            this.txtAnswerCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnswerCN.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtAnswerCN.Location = new System.Drawing.Point(592, 250);
            this.txtAnswerCN.Multiline = true;
            this.txtAnswerCN.Name = "txtAnswerCN";
            this.txtAnswerCN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswerCN.Size = new System.Drawing.Size(584, 185);
            this.txtAnswerCN.TabIndex = 7;
            this.txtAnswerCN.Enter += new System.EventHandler(this.txtAnswerCN_Enter);
            // 
            // txtAnswerEN
            // 
            this.txtAnswerEN.AcceptsReturn = true;
            this.txtAnswerEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnswerEN.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAnswerEN.Location = new System.Drawing.Point(3, 250);
            this.txtAnswerEN.Multiline = true;
            this.txtAnswerEN.Name = "txtAnswerEN";
            this.txtAnswerEN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswerEN.Size = new System.Drawing.Size(583, 185);
            this.txtAnswerEN.TabIndex = 6;
            // 
            // lblAnswerCN
            // 
            this.lblAnswerCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnswerCN.Location = new System.Drawing.Point(592, 219);
            this.lblAnswerCN.Name = "lblAnswerCN";
            this.lblAnswerCN.Size = new System.Drawing.Size(584, 28);
            this.lblAnswerCN.TabIndex = 5;
            this.lblAnswerCN.Text = "Answer (Chinese)";
            this.lblAnswerCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnswerEN
            // 
            this.lblAnswerEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnswerEN.Location = new System.Drawing.Point(3, 219);
            this.lblAnswerEN.Name = "lblAnswerEN";
            this.lblAnswerEN.Size = new System.Drawing.Size(583, 28);
            this.lblAnswerEN.TabIndex = 4;
            this.lblAnswerEN.Text = "Answer (English)";
            this.lblAnswerEN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuestionCN
            // 
            this.txtQuestionCN.AcceptsReturn = true;
            this.txtQuestionCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuestionCN.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtQuestionCN.Location = new System.Drawing.Point(592, 31);
            this.txtQuestionCN.Multiline = true;
            this.txtQuestionCN.Name = "txtQuestionCN";
            this.txtQuestionCN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestionCN.Size = new System.Drawing.Size(584, 185);
            this.txtQuestionCN.TabIndex = 3;
            this.txtQuestionCN.Enter += new System.EventHandler(this.txtQuestionCN_Enter);
            // 
            // lblQuestionCN
            // 
            this.lblQuestionCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionCN.Location = new System.Drawing.Point(592, 0);
            this.lblQuestionCN.Name = "lblQuestionCN";
            this.lblQuestionCN.Size = new System.Drawing.Size(584, 28);
            this.lblQuestionCN.TabIndex = 1;
            this.lblQuestionCN.Text = "Question (Chinese)";
            this.lblQuestionCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestionEN
            // 
            this.lblQuestionEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionEN.Location = new System.Drawing.Point(3, 0);
            this.lblQuestionEN.Name = "lblQuestionEN";
            this.lblQuestionEN.Size = new System.Drawing.Size(583, 28);
            this.lblQuestionEN.TabIndex = 0;
            this.lblQuestionEN.Text = "Question (English)";
            this.lblQuestionEN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuestionEN
            // 
            this.txtQuestionEN.AcceptsReturn = true;
            this.txtQuestionEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuestionEN.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtQuestionEN.Location = new System.Drawing.Point(3, 31);
            this.txtQuestionEN.Multiline = true;
            this.txtQuestionEN.Name = "txtQuestionEN";
            this.txtQuestionEN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestionEN.Size = new System.Drawing.Size(583, 185);
            this.txtQuestionEN.TabIndex = 2;
            // 
            // cboGenre
            // 
            this.cboGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(3, 469);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(583, 24);
            this.cboGenre.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(848, 525);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(968, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(1088, 525);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 582);
            this.Controls.Add(this.layoutMain);
            this.Name = "frmNewQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Question";
            this.Load += new System.EventHandler(this.frmNewQuestion_Load);
            this.layoutMain.ResumeLayout(false);
            this.layoutInput.ResumeLayout(false);
            this.layoutInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TableLayoutPanel layoutInput;
        private System.Windows.Forms.Label lblQuestionCN;
        private System.Windows.Forms.Label lblQuestionEN;
        private System.Windows.Forms.TextBox txtQuestionEN;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtAnswerCN;
        private System.Windows.Forms.TextBox txtAnswerEN;
        private System.Windows.Forms.Label lblAnswerCN;
        private System.Windows.Forms.Label lblAnswerEN;
        private System.Windows.Forms.TextBox txtQuestionCN;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}