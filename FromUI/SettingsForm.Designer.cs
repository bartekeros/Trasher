namespace FromUI
{
    partial class SettingsForm
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
            this.PathsLabel = new System.Windows.Forms.Label();
            this.PathsListBox = new System.Windows.Forms.ListBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.RemovePathButton = new System.Windows.Forms.Button();
            this.RemovePatternButton = new System.Windows.Forms.Button();
            this.PatternsListBox = new System.Windows.Forms.ListBox();
            this.PatternLabel = new System.Windows.Forms.Label();
            this.PatternTextBox = new System.Windows.Forms.TextBox();
            this.AddPatternButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathsLabel
            // 
            this.PathsLabel.AutoSize = true;
            this.PathsLabel.Location = new System.Drawing.Point(164, 24);
            this.PathsLabel.Name = "PathsLabel";
            this.PathsLabel.Size = new System.Drawing.Size(34, 13);
            this.PathsLabel.TabIndex = 0;
            this.PathsLabel.Text = "Paths";
            this.PathsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PathsListBox
            // 
            this.PathsListBox.FormattingEnabled = true;
            this.PathsListBox.Location = new System.Drawing.Point(12, 40);
            this.PathsListBox.Name = "PathsListBox";
            this.PathsListBox.Size = new System.Drawing.Size(346, 186);
            this.PathsListBox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(12, 233);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(165, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // RemovePathButton
            // 
            this.RemovePathButton.Location = new System.Drawing.Point(193, 233);
            this.RemovePathButton.Name = "RemovePathButton";
            this.RemovePathButton.Size = new System.Drawing.Size(165, 23);
            this.RemovePathButton.TabIndex = 3;
            this.RemovePathButton.Text = "Remove Path";
            this.RemovePathButton.UseVisualStyleBackColor = true;
            this.RemovePathButton.Click += new System.EventHandler(this.RemovePathButton_Click);
            // 
            // RemovePatternButton
            // 
            this.RemovePatternButton.Location = new System.Drawing.Point(443, 233);
            this.RemovePatternButton.Name = "RemovePatternButton";
            this.RemovePatternButton.Size = new System.Drawing.Size(345, 23);
            this.RemovePatternButton.TabIndex = 6;
            this.RemovePatternButton.Text = "Remove Pattern";
            this.RemovePatternButton.UseVisualStyleBackColor = true;
            this.RemovePatternButton.Click += new System.EventHandler(this.RemovePatternButton_Click);
            // 
            // PatternsListBox
            // 
            this.PatternsListBox.FormattingEnabled = true;
            this.PatternsListBox.Location = new System.Drawing.Point(443, 41);
            this.PatternsListBox.Name = "PatternsListBox";
            this.PatternsListBox.Size = new System.Drawing.Size(345, 186);
            this.PatternsListBox.TabIndex = 5;
            // 
            // PatternLabel
            // 
            this.PatternLabel.AutoSize = true;
            this.PatternLabel.Location = new System.Drawing.Point(583, 24);
            this.PatternLabel.Name = "PatternLabel";
            this.PatternLabel.Size = new System.Drawing.Size(46, 13);
            this.PatternLabel.TabIndex = 4;
            this.PatternLabel.Text = "Patterns";
            this.PatternLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatternTextBox
            // 
            this.PatternTextBox.Location = new System.Drawing.Point(443, 276);
            this.PatternTextBox.Name = "PatternTextBox";
            this.PatternTextBox.Size = new System.Drawing.Size(229, 20);
            this.PatternTextBox.TabIndex = 7;
            // 
            // AddPatternButton
            // 
            this.AddPatternButton.Location = new System.Drawing.Point(678, 274);
            this.AddPatternButton.Name = "AddPatternButton";
            this.AddPatternButton.Size = new System.Drawing.Size(110, 23);
            this.AddPatternButton.TabIndex = 8;
            this.AddPatternButton.Text = "Add Pattern";
            this.AddPatternButton.UseVisualStyleBackColor = true;
            this.AddPatternButton.Click += new System.EventHandler(this.AddPatternButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(0, 320);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(800, 41);
            this.ApplyButton.TabIndex = 9;
            this.ApplyButton.Text = "Apply and save settings";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.AddPatternButton);
            this.Controls.Add(this.PatternTextBox);
            this.Controls.Add(this.RemovePatternButton);
            this.Controls.Add(this.PatternsListBox);
            this.Controls.Add(this.PatternLabel);
            this.Controls.Add(this.RemovePathButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathsListBox);
            this.Controls.Add(this.PathsLabel);
            this.Name = "SettingsForm";
            this.Text = "Trasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathsLabel;
        private System.Windows.Forms.ListBox PathsListBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button RemovePathButton;
        private System.Windows.Forms.Button RemovePatternButton;
        private System.Windows.Forms.ListBox PatternsListBox;
        private System.Windows.Forms.Label PatternLabel;
        private System.Windows.Forms.TextBox PatternTextBox;
        private System.Windows.Forms.Button AddPatternButton;
        private System.Windows.Forms.Button ApplyButton;
    }
}

