using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface ISolutionTypeService
   {
      bool SolutionTypeExists (int id);
      bool SolutionTypeExists (string name);
      void AddSolutionType (SolutionType SolutionType);
      IEnumerable<SolutionType> GetSolutionTypes ();
      SolutionType GetSolutionType (int id);
      void UpdateSolutionType (SolutionType SolutionType);
   }
}
