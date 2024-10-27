using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionCreator.Refactoring
{
    public class RenameDirectory : IRenameDirectory
    {
        public async Task Rename(string solutionDestination,string fromProjectName, string toProjectName)
        {
            try
            {
                DirectoryInfo directories; 
                directories = new DirectoryInfo(solutionDestination);
                foreach (DirectoryInfo directory in directories.GetDirectories())
                {
                    //directory process
                    try
                    {
                        if (directory.Name.IndexOf(fromProjectName) >= 0)
                        {
                            Directory.Move(directory.FullName, directory.FullName.Replace(fromProjectName, toProjectName));
                        }
                        //directory process end
                    }
                    catch (Exception)
                    {

                    }
                    await Rename(directory.FullName.Replace(fromProjectName, toProjectName), fromProjectName, toProjectName);
                }
            }
            catch (Exception)
            {
            } 
        }
    }
}
