using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class ProjectStatusService : IProjectStatusService
   {
      private readonly JOINNDbContext _db;

      public ProjectStatusService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddProjectStatus (ProjectStatus ProjectStatus)
      {
         _db.Add (ProjectStatus);
         _db.SaveChanges ();
      }

      public ProjectStatus GetProjectStatus (int id)
      {
         return _db.ProjectStatus.Find (id);
      }

      public IEnumerable<ProjectStatus> GetProjectStatus ()
      {
         return _db.ProjectStatus
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateProjectStatus (ProjectStatus ProjectStatus)
      {
         _db.Entry (ProjectStatus).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool ProjectStatusExists (int id)
      {
         return _db.ProjectStatus.Any (r => r.ID == id);
      }

      public bool ProjectStatusExists (string name)
      {
         return _db.ProjectStatus.Any (r => r.Name == name);
      }
   }
}
