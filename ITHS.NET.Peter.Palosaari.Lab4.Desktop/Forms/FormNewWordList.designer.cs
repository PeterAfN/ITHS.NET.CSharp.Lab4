namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.Forms
{
    partial class FormNewWordList
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelNameList = new System.Windows.Forms.Label();
            this.textBoxNameList = new System.Windows.Forms.TextBox();
            this.panelData = new System.Windows.Forms.Panel();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.textBoxLanguages = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelNameList);
            this.panelTop.Controls.Add(this.textBoxNameList);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(245, 75);
            this.panelTop.TabIndex = 0;
            // 
            // labelNameList
            // 
            this.labelNameList.AutoSize = true;
            this.labelNameList.Location = new System.Drawing.Point(9, 25);
            this.labelNameList.Name = "labelNameList";
            this.labelNameList.Size = new System.Drawing.Size(106, 13);
            this.labelNameList.TabIndex = 0;
            this.labelNameList.Text = "Name of the new list:";
            // 
            // textBoxNameList
            // 
            this.textBoxNameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameList.Location = new System.Drawing.Point(12, 41);
            this.textBoxNameList.Name = "textBoxNameList";
            this.textBoxNameList.Size = new System.Drawing.Size(221, 20);
            this.textBoxNameList.TabIndex = 0;
            this.textBoxNameList.TextChanged += new System.EventHandler(this.TextBoxNameList_TextChanged);
            this.textBoxNameList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNameList_KeyPress);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.labelLanguages);
            this.panelData.Controls.Add(this.textBoxLanguages);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 75);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(245, 225);
            this.panelData.TabIndex = 1;
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point(12, 15);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(136, 13);
            this.labelLanguages.TabIndex = 0;
            this.labelLanguages.Text = "Language(s) in the new list:";
            // 
            // textBoxLanguages
            // 
            this.textBoxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLanguages.Location = new System.Drawing.Point(12, 34);
            this.textBoxLanguages.Multiline = true;
            this.textBoxLanguages.Name = "textBoxLanguages";
            this.textBoxLanguages.Size = new System.Drawing.Size(221, 138);
            this.textBoxLanguages.TabIndex = 1;
            this.textBoxLanguages.TextChanged += new System.EventHandler(this.TextBoxLanguages_TextChanged);
            this.textBoxLanguages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLanguages_KeyPress);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.buttonCreate);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 264);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(245, 36);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(158, 10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Location = new System.Drawing.Point(77, 10);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // FormNewWordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 311);
            this.ControlBox = false;
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 408);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(196, 244);
            this.Name = "FormNewWordList";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please enter the name and language(s):";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNameList;
        private System.Windows.Forms.Label labelLanguages;
        public System.Windows.Forms.Button buttonCreate;
        public System.Windows.Forms.TextBox textBoxNameList;
        public System.Windows.Forms.TextBox textBoxLanguages;
    }
}