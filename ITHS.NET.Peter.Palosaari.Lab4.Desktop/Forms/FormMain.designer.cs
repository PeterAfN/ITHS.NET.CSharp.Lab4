namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.Forms
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetActiveWordList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmRemovingWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmExitingProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelMode = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(855, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewListToolStripMenuItem,
            this.ToolStripMenuItemSetActiveWordList,
            this.toolStripMenuItemExit});
            this.ToolStripMenuItemFile.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(37, 18);
            this.ToolStripMenuItemFile.Text = "File";
            // 
            // createNewListToolStripMenuItem
            // 
            this.createNewListToolStripMenuItem.Name = "createNewListToolStripMenuItem";
            this.createNewListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.createNewListToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.createNewListToolStripMenuItem.Text = "Create new word list";
            this.createNewListToolStripMenuItem.Click += new System.EventHandler(this.CreateNewListToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemSetActiveWordList
            // 
            this.ToolStripMenuItemSetActiveWordList.Name = "ToolStripMenuItemSetActiveWordList";
            this.ToolStripMenuItemSetActiveWordList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemSetActiveWordList.Size = new System.Drawing.Size(219, 22);
            this.ToolStripMenuItemSetActiveWordList.Text = "Set active word list";
            this.ToolStripMenuItemSetActiveWordList.Click += new System.EventHandler(this.ToolStripMenuItemSetActiveWordList_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItemExit_MouseDown);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmRemovingWordsToolStripMenuItem,
            this.confirmExitingProgramToolStripMenuItem});
            this.settingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 18);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // confirmRemovingWordsToolStripMenuItem
            // 
            this.confirmRemovingWordsToolStripMenuItem.Checked = true;
            this.confirmRemovingWordsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.confirmRemovingWordsToolStripMenuItem.Name = "confirmRemovingWordsToolStripMenuItem";
            this.confirmRemovingWordsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.confirmRemovingWordsToolStripMenuItem.Text = "Confirm removing words";
            this.confirmRemovingWordsToolStripMenuItem.Click += new System.EventHandler(this.ConfirmRemovingWordsToolStripMenuItem_Click);
            // 
            // confirmExitingProgramToolStripMenuItem
            // 
            this.confirmExitingProgramToolStripMenuItem.Checked = true;
            this.confirmExitingProgramToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.confirmExitingProgramToolStripMenuItem.Name = "confirmExitingProgramToolStripMenuItem";
            this.confirmExitingProgramToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.confirmExitingProgramToolStripMenuItem.Text = "Confirm exiting program";
            this.confirmExitingProgramToolStripMenuItem.Click += new System.EventHandler(this.ConfirmExitingProgramToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 18);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 29);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(672, 308);
            this.panelData.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 337);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(672, 40);
            this.panelButtons.TabIndex = 2;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.BackColor = System.Drawing.Color.White;
            this.comboBoxMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Edit",
            "Practice"});
            this.comboBoxMode.Location = new System.Drawing.Point(541, 3);
            this.comboBoxMode.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMode.TabIndex = 0;
            this.comboBoxMode.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxMode_SelectionChangeCommitted);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelMode);
            this.panelTop.Controls.Add(this.comboBoxMode);
            this.panelTop.Controls.Add(this.menuStripMain);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 3, 10, 0);
            this.panelTop.Size = new System.Drawing.Size(672, 29);
            this.panelTop.TabIndex = 0;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMode.Location = new System.Drawing.Point(504, 3);
            this.labelMode.Name = "labelMode";
            this.labelMode.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelMode.Size = new System.Drawing.Size(37, 17);
            this.labelMode.TabIndex = 3;
            this.labelMode.Text = "Mode:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 388);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelButtons);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(341, 317);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glosor v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetActiveWordList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        public System.Windows.Forms.Panel panelButtons;
        public System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.ToolStripMenuItem createNewListToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelMode;
        public System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmRemovingWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmExitingProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

