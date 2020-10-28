namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.UserControls
{
    partial class UserControlPractice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDivider = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelResult2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDivider
            // 
            this.labelDivider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDivider.AutoSize = true;
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(164, 175);
            this.labelDivider.MaximumSize = new System.Drawing.Size(0, 2);
            this.labelDivider.MinimumSize = new System.Drawing.Size(300, 2);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(300, 2);
            this.labelDivider.TabIndex = 2;
            this.labelDivider.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResult.AutoSize = true;
            this.labelResult.ForeColor = System.Drawing.Color.Green;
            this.labelResult.Location = new System.Drawing.Point(244, 193);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(130, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "2 of 3 words were correct.";
            this.labelResult.Visible = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnswer.Location = new System.Drawing.Point(218, 134);
            this.textBoxAnswer.MaximumSize = new System.Drawing.Size(190, 20);
            this.textBoxAnswer.MinimumSize = new System.Drawing.Size(190, 20);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(190, 20);
            this.textBoxAnswer.TabIndex = 0;
            this.textBoxAnswer.Visible = false;
            this.textBoxAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAnswer_KeyDown);
            this.textBoxAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAnswer_KeyPress);
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(205, 104);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(216, 13);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Translate the Swedish word \'nivå\' to english.";
            this.labelQuestion.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.Color.Green;
            this.labelInfo.Location = new System.Drawing.Point(414, 137);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(81, 13);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Correct answer!";
            this.labelInfo.Visible = false;
            // 
            // labelResult2
            // 
            this.labelResult2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResult2.AutoSize = true;
            this.labelResult2.ForeColor = System.Drawing.Color.Green;
            this.labelResult2.Location = new System.Drawing.Point(220, 219);
            this.labelResult2.Name = "labelResult2";
            this.labelResult2.Size = new System.Drawing.Size(181, 13);
            this.labelResult2.TabIndex = 4;
            this.labelResult2.Text = "93,2 % of your answers were correct!";
            this.labelResult2.Visible = false;
            // 
            // UserControlPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelResult2);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.labelResult);
            this.DoubleBuffered = true;
            this.Name = "UserControlPractice";
            this.Size = new System.Drawing.Size(634, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelResult2;
    }
}
