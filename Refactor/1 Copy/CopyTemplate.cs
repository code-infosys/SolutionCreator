using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace SolutionCreator.Refactoring
{
    public class CopyTemplate : ICopyTemplate
    {
        public async Task Copy(string solutionSource, string solutionDestination, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(solutionSource);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + solutionSource);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(solutionDestination))
            {
                DirectoryInfo dirDest = new DirectoryInfo(solutionDestination);
                dirDest.Create();
                if (dir.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    dirDest.Attributes |= FileAttributes.Hidden;
                }
                //Directory.CreateDirectory(solutionDestination);
            }

            // Get the files in the directory and copy them to the new location.

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                try
                {
                    //string temppath = Path.Combine(solutionDestination, file.Name);
                    //file.CopyTo(temppath, false);

                    if ((file.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden || (file.Attributes & FileAttributes.System) == FileAttributes.System)
                    {
                        file.Attributes |= FileAttributes.Hidden;
                    }

                    string temppath = Path.Combine(solutionDestination, file.Name);

                    if (!File.Exists(temppath)) //if file not exists at destination then it will copy it
                    {
                        await Task.Run(() =>
                        {
                            file.CopyTo(temppath, false);
                        });
                    }
                     
                }
                catch (Exception)
                {
                    continue; 
                }
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(solutionDestination, subdir.Name);
                    await Copy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

    }
}
