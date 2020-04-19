using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RubbishLibrary;

namespace FromUI
{
    public partial class DeleteFilesForm : Form
    {
        private RubbishRemover rubbishRemover;
        private List<string> filesToRemove;

        public DeleteFilesForm(List<string> paths, List<string> patterns)
        {
            InitializeComponent();

            rubbishRemover = new RubbishRemover();

            DisplayRubbishPaths.CheckOnClick = true;
            Task.Run(() => InitializePaths(paths, patterns));
        }

        private async Task InitializePaths(List<string> paths, List<string> patterns)
        {
            await filesToRemove = rubbishRemover.FindRubbish(paths, patterns).ToList();

            DisplayPaths(true);
        }

        private void DisplayPaths(bool makeItemsChecked)
        {
            DisplayRubbishPaths.Items.Clear();

            foreach (string file in filesToRemove)
            {
                DisplayRubbishPaths.Items.Add(file, makeItemsChecked);
            }
        }

        private void DeleteRubbish_Click(object sender, EventArgs e)
        {
            var checkedPaths = new List<string>();

            checkedPaths.AddRange(DisplayRubbishPaths.CheckedItems.OfType<string>());

            DialogResult dialogResult = MessageBox.Show("Do you really want to delete all files? It can't be undo!", 
                                                        "Delete files", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                if (removeDirecoriesCheckBox.Checked == true)
                {
                    rubbishRemover.RemoveRubbish(checkedPaths, true,  SettingsForm.pathsManager);
                }
                else
                {
                    rubbishRemover.RemoveRubbish(checkedPaths);
                }

                filesToRemove = filesToRemove.Except(checkedPaths).ToList();

                DisplayPaths(false);
            }
        }
    }
}
