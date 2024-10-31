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

        private void TemplateFileGenerator_Load(object sender, EventArgs e)
        {
           var lastlog = File.ReadAllText(Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "lastlog.txt"));
            if (!string.IsNullOrEmpty(lastlog))
            {
                txtDeleteJsonPath.Text = lastlog;
            }
        }

        private List<FileSaveInfo> fileSaveInfos = new List<FileSaveInfo>();
        private List<FileSaveInfo> loggedFiles = new List<FileSaveInfo>();
        private void btnGenerate_Click(object sender, EventArgs e)
        { 
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
             
            string folderPath = txtFolderName.Text;
            string tableName = txtTableName.Text;
            
            if (string.IsNullOrEmpty(folderPath) || string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(txtNameSpace.Text))
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
                ProcessDirectory(templateFolderPath, outputFolder);
                SaveLogToJson(outputFolder, projectDirectory);
                MessageBox.Show("Files generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ProcessDirectory(string sourceDir, string targetDir)
        { 
            Directory.CreateDirectory(targetDir);
             
            foreach (string filePath in Directory.GetFiles(sourceDir))
            {
                if (Path.GetFileName(filePath) != "MetaData.json")
                    ProcessFile(filePath, targetDir);
            }
             
            foreach (string subDir in Directory.GetDirectories(sourceDir))
            { 
                string newTargetSubDir = Path.Combine(targetDir, Path.GetFileName(subDir).Replace("#TableName#", txtTableName.Text));
                ProcessDirectory(subDir, newTargetSubDir);
            }
        }

        private void ProcessFile(string filePath, string targetDir)
        {
            string fileName = Path.GetFileName(filePath);
    
            string newFileName = fileName.Replace("#TableName#", txtTableName.Text);
            string newFilePath = Path.Combine(targetDir, newFileName);
             
            var contentBuilder = new StringBuilder(File.ReadAllText(filePath));
            contentBuilder.Replace("#TableName#", txtTableName.Text);
            contentBuilder.Replace("#NameSpace#", txtNameSpace.Text);
            string content = contentBuilder.ToString();
            if (chkSaveDirectToProject.Checked)
            {
                var fileInfo = fileSaveInfos.FirstOrDefault(info => info.FileName == fileName);
                if (fileInfo != null && !string.IsNullOrEmpty(fileInfo.SavePath))
                {
                    if (Directory.Exists(fileInfo.SavePath))
                    {
                        newFilePath = Path.Combine(fileInfo.SavePath, newFileName);
                        loggedFiles.Add(new FileSaveInfo { SavePath = newFilePath });
                    }
                }

                File.WriteAllText(newFilePath, content);  
            }
            else
            {
                File.WriteAllText(newFilePath, content);
            }
        }

        private void SaveLogToJson(string outPutFolder, string projectDirectory)
        {
            if (loggedFiles.Any())
            {
                string logFilePath = Path.Combine(outPutFolder, "log.json");
                File.WriteAllText(logFilePath, JsonConvert.SerializeObject(loggedFiles, Formatting.Indented));
                txtDeleteJsonPath.Text = logFilePath;

                //save last path till next generate
                File.WriteAllText(Path.Combine(projectDirectory, "lastlog.txt"), logFilePath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(txtDeleteJsonPath.Text))
            {
                MessageBox.Show("Please fill Delete path.");
                return;
            }

            string logFilePath = txtDeleteJsonPath.Text;

            if (File.Exists(logFilePath))
            {
                var loggedFiles = JsonConvert.DeserializeObject<List<FileSaveInfo>>(File.ReadAllText(logFilePath));
                if (loggedFiles.Any())
                {
                    foreach (var fileInfo in loggedFiles)
                    {
                        if (File.Exists(fileInfo.SavePath))
                        {
                            File.Delete(fileInfo.SavePath); // Delete the file
                        }
                    }

                    // Optionally, clear the log file after deletion
                    File.WriteAllText(logFilePath, "[]"); // Clear the log
                    MessageBox.Show("Deleted done.");
                }
                
            }
        }

        
    }

    public class FileSaveInfo
    {
        public string FileName { get; set; }
        public string SavePath { get; set; }
    }
}
