using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolutionCreator.Refactoring;
namespace SolutionCreator
{
    public partial class SC : Form
    {
        public SC()
        {
            InitializeComponent();
        }
        private void SC_Load(object sender, EventArgs e)
        {
            txtSourceUrl.Text = @"F:\Si Process works\ProjectTesting\A Sample Identity";
            txtDestinationUrl.Text = @"F:\Si Process works\ProjectTesting\YourProjectName";
            txtSourceSolutionName.Text = "AspNetIdentity";
            txtNewSolutionName.Text = "YourProjectName";
        }

        public async void btnGenerate_Click(object sender, EventArgs e)
        {
            lblProcess.Text = "Process Started...";
            lblProcess.Refresh();

            ProgressBar.Value = 30;
            ProgressBar.Refresh();
            lblProcess.Text = "30%";
            lblProcess.Refresh();


            string solutionSource = txtSourceUrl.Text; //source directory
            string solutionDestination = txtDestinationUrl.Text; //destination directory

            if (!Directory.Exists(solutionDestination))
            { 
                ICopyTemplate copyTemplate = new CopyTemplate();
                await copyTemplate.Copy(solutionSource, solutionDestination, true);
                ProgressBar.Value = 40;
                ProgressBar.Refresh();
                IRenameDirectory renameDirectory = new RenameDirectory();
                await renameDirectory.Rename(solutionDestination, txtSourceSolutionName.Text, txtNewSolutionName.Text);
                ProgressBar.Value = 60;
                ProgressBar.Refresh();
                IRenameFiles renameFiles = new RenameFiles();
                await renameFiles.Rename(solutionDestination, txtSourceSolutionName.Text, txtNewSolutionName.Text);
                ProgressBar.Value = 80;
                ProgressBar.Refresh();
                IFileContent fileContent = new FileContent();
                await fileContent.Replace(solutionDestination, txtSourceSolutionName.Text, txtNewSolutionName.Text);

            }
            else
            {
                MessageBox.Show("Destination directory already exists");
            }
            ProgressBar.Value = 100;
            ProgressBar.Refresh();

            lblProcess.Text = "100%";
            lblProcess.Refresh();
            MessageBox.Show("Done");
        }



         

    }
}
