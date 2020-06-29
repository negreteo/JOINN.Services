using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class ProjectTypeService : IProjectTypeService
   {
      private readonly JOINNDbContext _db;

      public ProjectTypeService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddProjectType (ProjectType ProjectType)
      {
         _db.Add (ProjectType);
         _db.SaveChanges ();
      }

      public ProjectType GetProjectType (int id)
      {
         return _db.ProjectTypes.Find (id);
      }

      public IEnumerable<ProjectType> GetProjectTypes ()
      {
         return _db.ProjectTypes
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateProjectType (ProjectType ProjectType)
      {
         _db.Entry (ProjectType).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool ProjectTypeExists (int id)
      {
         return _db.ProjectTypes.Any (r => r.ID == id);
      }

      public bool ProjectTypeExists (string name)
      {
         return _db.ProjectTypes.Any (r => r.Name == name);
      }
   }
}
