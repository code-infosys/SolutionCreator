using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolutionCreator
{
    public partial class TemplateFileGenerator : Form
    {
        public TemplateFileGenerator()
        {
            InitializeComponent();
        }
        private List<FileSaveInfo> fileSaveInfos = new List<FileSaveInfo>();
        private void btnGenerate_Click(object sender, EventArgs e)
        { 
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
             
            string folderPath = txtFolderName.Text;
            string tableName = txtTableName.Text;
            string namespaceName = txtNameSpace.Text;

            if (string.IsNullOrEmpty(folderPath) || string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(namespaceName))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string templateFolderPath = Path.Combine(projectDirectory, "Template", folderPath);

            if (chkSaveDirectToProject.Checked)
            {
                //get metaData file
                var metaData = File.ReadAllText(Path.Combine(templateFolderPath, "MetaData.json"));
                fileSaveInfos = JsonConvert.DeserializeObject<List<FileSaveInfo>>(metaData);
            }
            
            string outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", tableName);

            try
            { 
                ProcessDirectory(templateFolderPath, outputFolder, tableName, namespaceName);
                MessageBox.Show("Files generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ProcessDirectory(string sourceDir, string targetDir, string tableName, string namespaceName)
        { 
            Directory.CreateDirectory(targetDir);
             
            foreach (string filePath in Directory.GetFiles(sourceDir))
            {
                if (Path.GetFileName(filePath) != "MetaData.json")
                    ProcessFile(filePath, targetDir, tableName, namespaceName);
            }
             
            foreach (string subDir in Directory.GetDirectories(sourceDir))
            { 
                string newTargetSubDir = Path.Combine(targetDir, Path.GetFileName(subDir).Replace("#TableName#", tableName));
                ProcessDirectory(subDir, newTargetSubDir, tableName, namespaceName);
            }
        }

        private void ProcessFile(string filePath, string targetDir, string tableName, string namespaceName)
        {
            string fileName = Path.GetFileName(filePath);
    
            string newFileName = fileName.Replace("#TableName#", tableName);
            string newFilePath = Path.Combine(targetDir, newFileName);
             
            var contentBuilder = new StringBuilder(File.ReadAllText(filePath));
            contentBuilder.Replace("#TableName#", tableName);
            contentBuilder.Replace("#NameSpace#", namespaceName);
            string content = contentBuilder.ToString();
            if (chkSaveDirectToProject.Checked)
            {
                var fileInfo = fileSaveInfos.FirstOrDefault(info => info.FileName == fileName);
                if (fileInfo != null && !string.IsNullOrEmpty(fileInfo.SavePath))
                {
                    newFilePath = Path.Combine(fileInfo.SavePath, newFileName); 
                }

                File.WriteAllText(newFilePath, content);  
            }
            else
            {
                File.WriteAllText(newFilePath, content);
            }
        }

    }

    public class FileSaveInfo
    {
        public string FileName { get; set; }
        public string SavePath { get; set; }
    }
}
