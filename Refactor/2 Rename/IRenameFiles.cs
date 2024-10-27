using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionCreator.Refactoring
{
    public interface IRenameFiles
    {
        Task Rename(string solutionDestination, string fromProjectName, string toProjectName);
    }
}
