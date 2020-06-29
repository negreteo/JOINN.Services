using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IProjectFunctionService
   {
      bool ProjectFunctionExists (int id);
      bool ProjectFunctionExists (string name);
      void AddProjectFunction (ProjectFunction ProjectFunction);
      IEnumerable<ProjectFunction> GetProjectFunctions ();
      ProjectFunction GetProjectFunction (int id);
      void UpdateProjectFunction (ProjectFunction ProjectFunction);
   }
}
