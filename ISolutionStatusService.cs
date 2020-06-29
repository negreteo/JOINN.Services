using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface ISolutionStatusService
   {
      bool SolutionStatusExists (int id);
      bool SolutionStatusExists (string name);
      void AddSolutionStatus (SolutionStatus SolutionStatus);
      IEnumerable<SolutionStatus> GetSolutionStatus ();
      SolutionStatus GetSolutionStatus (int id);
      void UpdateSolutionStatus (SolutionStatus SolutionStatus);
   }
}
