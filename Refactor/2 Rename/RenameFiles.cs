using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionCreator.Refactoring
{
    public class RenameFiles : IRenameFiles
    {
        public async Task Rename(string solutionDestination, string fromProjectName, string toProjectName)
        { 
            DirectoryInfo directory = new DirectoryInfo(solutionDestination);
            FileInfo[] files = directory.GetFiles();

            files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Name.IndexOf(fromProjectName) >= 0)
                {
                    System.IO.File.Move(file.FullName, file.FullName.Replace(fromProjectName, toProjectName));
                }
            }

            DirectoryInfo directories = new DirectoryInfo(solutionDestination);
            foreach (DirectoryInfo dir in directories.GetDirectories())
                await Rename(dir.FullName, fromProjectName, toProjectName);

        }
    }
}
