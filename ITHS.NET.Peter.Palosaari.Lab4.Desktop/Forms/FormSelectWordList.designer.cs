namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.Forms
{
    partial class FormSelectWordList
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.splitContainerWordLists = new System.Windows.Forms.SplitContainer();
            this.listBoxWordLists = new System.Windows.Forms.ListBox();
            this.panelWordLists = new System.Windows.Forms.Panel();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.labelWordLists = new System.Windows.Forms.Label();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.panelLanguages = new System.Windows.Forms.Panel();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.panelSplitContainer = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWordLists)).BeginInit();
            this.splitContainerWordLists.Panel1.SuspendLayout();
            this.splitContainerWordLists.Panel2.SuspendLayout();
            this.splitContainerWordLists.SuspendLayout();
            this.panelWordLists.SuspendLayout();
            this.panelLanguages.SuspendLayout();
            this.panelSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.buttonSelect);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 230);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(450, 36);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(363, 10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.Enabled = false;
            this.buttonSelect.Location = new System.Drawing.Point(282, 10);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // splitContainerWordLists
            // 
            this.splitContainerWordLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerWordLists.Location = new System.Drawing.Point(12, 14);
            this.splitContainerWordLists.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerWordLists.Name = "splitContainerWordLists";
            // 
            // splitContainerWordLists.Panel1
            // 
            this.splitContainerWordLists.Panel1.Controls.Add(this.listBoxWordLists);
            this.splitContainerWordLists.Panel1.Controls.Add(this.panelWordLists);
            // 
            // splitContainerWordLists.Panel2
            // 
            this.splitContainerWordLists.Panel2.Controls.Add(this.listBoxLanguages);
            this.splitContainerWordLists.Panel2.Controls.Add(this.panelLanguages);
            this.splitContainerWordLists.Size = new System.Drawing.Size(426, 216);
            this.splitContainerWordLists.SplitterDistance = 204;
            this.splitContainerWordLists.TabIndex = 1;
            // 
            // listBoxWordLists
            // 
            this.listBoxWordLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxWordLists.FormattingEnabled = true;
            this.listBoxWordLists.Location = new System.Drawing.Point(0, 13);
            this.listBoxWordLists.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxWordLists.Name = "listBoxWordLists";
            this.listBoxWordLists.Size = new System.Drawing.Size(204, 203);
            this.listBoxWordLists.TabIndex = 0;
            this.listBoxWordLists.SelectedIndexChanged += new System.EventHandler(this.ListBoxWordLists_SelectedIndexChanged);
            // 
            // panelWordLists
            // 
            this.panelWordLists.Controls.Add(this.labelWordCount);
            this.panelWordLists.Controls.Add(this.labelWordLists);
            this.panelWordLists.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWordLists.Location = new System.Drawing.Point(0, 0);
            this.panelWordLists.Margin = new System.Windows.Forms.Padding(0);
            this.panelWordLists.Name = "panelWordLists";
            this.panelWordLists.Size = new System.Drawing.Size(204, 13);
            this.panelWordLists.TabIndex = 1;
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelWordCount.Location = new System.Drawing.Point(204, 0);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(0, 13);
            this.labelWordCount.TabIndex = 1;
            // 
            // labelWordLists
            // 
            this.labelWordLists.AutoSize = true;
            this.labelWordLists.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelWordLists.Location = new System.Drawing.Point(0, 0);
            this.labelWordLists.Name = "labelWordLists";
            this.labelWordLists.Size = new System.Drawing.Size(120, 13);
            this.labelWordLists.TabIndex = 0;
            this.labelWordLists.Text = "List of word translations:";
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.Location = new System.Drawing.Point(0, 13);
            this.listBoxLanguages.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxLanguages.Size = new System.Drawing.Size(218, 203);
            this.listBoxLanguages.TabIndex = 1;
            // 
            // panelLanguages
            // 
            this.panelLanguages.Controls.Add(this.labelLanguages);
            this.panelLanguages.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLanguages.Location = new System.Drawing.Point(0, 0);
            this.panelLanguages.Name = "panelLanguages";
            this.panelLanguages.Size = new System.Drawing.Size(218, 13);
            this.panelLanguages.TabIndex = 1;
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLanguages.Location = new System.Drawing.Point(0, 0);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(63, 13);
            this.labelLanguages.TabIndex = 0;
            this.labelLanguages.Text = "Languages:";
            // 
            // panelSplitContainer
            // 
            this.panelSplitContainer.Controls.Add(this.splitContainerWordLists);
            this.panelSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.panelSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelSplitContainer.Name = "panelSplitContainer";
            this.panelSplitContainer.Padding = new System.Windows.Forms.Padding(12, 14, 12, 0);
            this.panelSplitContainer.Size = new System.Drawing.Size(450, 230);
            this.panelSplitContainer.TabIndex = 0;
            // 
            // FormSelectWordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 277);
            this.ControlBox = false;
            this.Controls.Add(this.panelSplitContainer);
            this.Controls.Add(this.panelButtons);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(882, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 166);
            this.Name = "FormSelectWordList";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "To view a list, please select one:";
            this.Shown += new System.EventHandler(this.FormSelectWordList_Shown);
            this.panelButtons.ResumeLayout(false);
            this.splitContainerWordLists.Panel1.ResumeLayout(false);
            this.splitContainerWordLists.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWordLists)).EndInit();
            this.splitContainerWordLists.ResumeLayout(false);
            this.panelWordLists.ResumeLayout(false);
            this.panelWordLists.PerformLayout();
            this.panelLanguages.ResumeLayout(false);
            this.panelLanguages.PerformLayout();
            this.panelSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerWordLists;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.Panel panelSplitContainer;
        private System.Windows.Forms.Panel panelWordLists;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.Label labelWordLists;
        private System.Windows.Forms.Panel panelLanguages;
        private System.Windows.Forms.Label labelLanguages;
        public System.Windows.Forms.Panel panelButtons;
        public System.Windows.Forms.Button buttonSelect;
        public System.Windows.Forms.ListBox listBoxWordLists;
        public System.Windows.Forms.Button buttonCancel;
    }
}