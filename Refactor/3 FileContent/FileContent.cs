using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionCreator.Refactoring
{
    public class FileContent : IFileContent
    {
        public async Task Replace(string solutionDestination, string fromProjectName, string toProjectName)
        { 
            DirectoryInfo directory = new DirectoryInfo(solutionDestination);
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                StreamReader reader = new StreamReader(System.IO.File.Open(file.FullName, System.IO.FileMode.Open));
                string tmp = reader.ReadToEnd();
                string newText = tmp.Replace(fromProjectName, toProjectName);
                reader.Close();
                if (newText.IndexOf(toProjectName) >= 0)
                {
                    try
                    {
                        TextWriter tw = new StreamWriter(file.FullName);
                        tw.WriteLine(newText);
                        tw.Close();
                    }
                    catch (Exception)
                    {
                    }
                } 
            }

            DirectoryInfo directories = new DirectoryInfo(solutionDestination);
            foreach (DirectoryInfo dir in directories.GetDirectories())
               await Replace(dir.FullName, fromProjectName, toProjectName); 
        }
    }
}
