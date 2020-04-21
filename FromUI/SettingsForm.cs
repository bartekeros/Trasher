using RubbishLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromUI
{
    public partial class SettingsForm : Form
    {
        static internal PathsManager pathsManager;
        private PatternsManager patternsManager;
        private ObservableCollection<string> paths;
        private ObservableCollection<string> patterns;
        public SettingsForm()
        {
            InitializeComponent();

            pathsManager = new PathsManager();
            patternsManager = new PatternsManager();
            paths = new ObservableCollection<string>();
            patterns = new ObservableCollection<string>();

            UpdateListOfPaths();
            UpdateListOfPatterns();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog choosePath = new FolderBrowserDialog();
            
            if(choosePath.ShowDialog() == DialogResult.OK)
            {
                pathsManager.AddPath(choosePath.SelectedPath); 
            }

            UpdateListOfPaths();
        }
        private void RemovePathButton_Click(object sender, EventArgs e)
        {
            pathsManager.RemovePath(PathsListBox.SelectedItem.ToString());

            UpdateListOfPaths();
        }


        private void AddPatternButton_Click(object sender, EventArgs e)
        {
            string pattern = PatternTextBox.Text;
            PatternTextBox.Text = string.Empty;

            patternsManager.AddPattern(pattern);

            UpdateListOfPatterns();
        }
        private void RemovePatternButton_Click(object sender, EventArgs e)
        {
            patternsManager.RemovePath(PatternsListBox.SelectedItem.ToString());

            UpdateListOfPatterns();
        }

        private void UpdateListOfPaths()
        {
            paths.Clear();

            foreach (string path in pathsManager.GetPaths())
            {
                paths.Add(path);
            }

            PathsListBox.DataSource = null;
            PathsListBox.DataSource = paths;
        }

        private void UpdateListOfPatterns()
        {
            patterns.Clear();

            foreach (string pattern in patternsManager.GetPatterns())
            {
                patterns.Add(pattern);
            }

            PatternsListBox.DataSource = null;
            PatternsListBox.DataSource = patterns;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var deleteFilesForm = new DeleteFilesForm(paths.ToList(), patterns.ToList());

            deleteFilesForm.ShowDialog();

            this.Close();
        }
    }
}
