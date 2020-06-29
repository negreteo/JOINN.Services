using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IProjectTypeService
   {
      bool ProjectTypeExists (int id);
      bool ProjectTypeExists (string name);
      void AddProjectType (ProjectType ProjectType);
      IEnumerable<ProjectType> GetProjectTypes ();
      ProjectType GetProjectType (int id);
      void UpdateProjectType (ProjectType ProjectType);
   }
}
