using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IProjectStatusService
   {
      bool ProjectStatusExists (int id);
      bool ProjectStatusExists (string name);
      void AddProjectStatus (ProjectStatus ProjectStatus);
      IEnumerable<ProjectStatus> GetProjectStatus ();
      ProjectStatus GetProjectStatus (int id);
      void UpdateProjectStatus (ProjectStatus ProjectStatus);
   }
}
