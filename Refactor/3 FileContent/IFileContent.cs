using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionCreator.Refactoring
{
    public interface IFileContent
    {
        Task Replace(string solutionDestination, string fromProjectName, string toProjectName);
    }
}
