using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface ISolutionFileService
   {
      bool SolutionFileExists (int id);
      bool SolutionFileExists (string name);
      void AddSolutionFile (SolutionFile SolutionFile);
      IEnumerable<SolutionFile> GetSolutionFiles ();
      SolutionFile GetSolutionFile (int id);
      void UpdateSolutionFile (SolutionFile SolutionFile);
   }
}
