using System.Collections.Generic;
using JOINN.Data;
using JOINN.Data.Models;
using JOINN.Services.Models;

namespace JOINN.Services
{
   public interface ISolutionService
   {
      bool SolutionExists (int id);
      bool SolutionExists (string name);
      void AddSolution (Solution Solution);
      IEnumerable<SolutionView> GetSolutions ();
      Solution GetSolution (int id);
      void UpdateSolution (Solution Solution);
   }
}
