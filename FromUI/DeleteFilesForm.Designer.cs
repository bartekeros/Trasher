namespace FromUI
{
    partial class DeleteFilesForm
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
            this.DisplayRubbishPaths = new System.Windows.Forms.CheckedListBox();
            this.DeleteRubbish = new System.Windows.Forms.Button();
            this.removeDirecoriesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DisplayRubbishPaths
            // 
            this.DisplayRubbishPaths.FormattingEnabled = true;
            this.DisplayRubbishPaths.Location = new System.Drawing.Point(-1, 0);
            this.DisplayRubbishPaths.Name = "DisplayRubbishPaths";
            this.DisplayRubbishPaths.Size = new System.Drawing.Size(802, 424);
            this.DisplayRubbishPaths.TabIndex = 0;
            // 
            // DeleteRubbish
            // 
            this.DeleteRubbish.Location = new System.Drawing.Point(475, 427);
            this.DeleteRubbish.Name = "DeleteRubbish";
            this.DeleteRubbish.Size = new System.Drawing.Size(322, 21);
            this.DeleteRubbish.TabIndex = 1;
            this.DeleteRubbish.Text = "Clear All Rubbish";
            this.DeleteRubbish.UseVisualStyleBackColor = true;
            this.DeleteRubbish.Click += new System.EventHandler(this.DeleteRubbish_Click);
            // 
            // removeDirecoriesCheckBox
            // 
            this.removeDirecoriesCheckBox.AutoSize = true;
            this.removeDirecoriesCheckBox.Checked = true;
            this.removeDirecoriesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeDirecoriesCheckBox.Location = new System.Drawing.Point(324, 430);
            this.removeDirecoriesCheckBox.Name = "removeDirecoriesCheckBox";
            this.removeDirecoriesCheckBox.Size = new System.Drawing.Size(145, 17);
            this.removeDirecoriesCheckBox.TabIndex = 2;
            this.removeDirecoriesCheckBox.Text = "Delete empty directories?";
            this.removeDirecoriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeleteFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeDirecoriesCheckBox);
            this.Controls.Add(this.DeleteRubbish);
            this.Controls.Add(this.DisplayRubbishPaths);
            this.Name = "DeleteFilesForm";
            this.Text = "DeleteFilesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox DisplayRubbishPaths;
        private System.Windows.Forms.Button DeleteRubbish;
        private System.Windows.Forms.CheckBox removeDirecoriesCheckBox;
    }
}