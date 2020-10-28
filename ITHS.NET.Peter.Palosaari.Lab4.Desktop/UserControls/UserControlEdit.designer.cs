namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.UserControls
{
    partial class UserControlEdit
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
            this.dataGridViewTranslations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranslations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTranslations
            // 
            this.dataGridViewTranslations.AllowUserToAddRows = false;
            this.dataGridViewTranslations.AllowUserToDeleteRows = false;
            this.dataGridViewTranslations.AllowUserToResizeColumns = false;
            this.dataGridViewTranslations.AllowUserToResizeRows = false;
            this.dataGridViewTranslations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTranslations.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewTranslations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTranslations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTranslations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTranslations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTranslations.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTranslations.Name = "dataGridViewTranslations";
            this.dataGridViewTranslations.ReadOnly = true;
            this.dataGridViewTranslations.RowHeadersVisible = false;
            this.dataGridViewTranslations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTranslations.Size = new System.Drawing.Size(611, 388);
            this.dataGridViewTranslations.TabIndex = 0;
            this.dataGridViewTranslations.SelectionChanged += new System.EventHandler(this.DataGridViewTranslations_SelectionChanged);
            // 
            // UserControlEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTranslations);
            this.DoubleBuffered = true;
            this.Name = "UserControlEdit";
            this.Size = new System.Drawing.Size(611, 388);
            this.Load += new System.EventHandler(this.UserControlEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranslations)).EndInit();
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.DataGridView dataGridViewTranslations;

        #endregion
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
