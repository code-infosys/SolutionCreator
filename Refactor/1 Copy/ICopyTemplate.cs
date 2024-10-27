using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionCreator.Refactoring
{
    public interface ICopyTemplate
    {
        Task Copy(string solutionSource, string solutionDestination, bool copySubDirs);
    }
}
