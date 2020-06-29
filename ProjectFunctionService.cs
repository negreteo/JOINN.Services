using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class ProjectFunctionService : IProjectFunctionService
   {
      private readonly JOINNDbContext _db;

      public ProjectFunctionService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddProjectFunction (ProjectFunction ProjectFunction)
      {
         _db.Add (ProjectFunction);
         _db.SaveChanges ();
      }

      public ProjectFunction GetProjectFunction (int id)
      {
         return _db.ProjectFunctions.Find (id);
      }

      public IEnumerable<ProjectFunction> GetProjectFunctions ()
      {
         return _db.ProjectFunctions
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateProjectFunction (ProjectFunction ProjectFunction)
      {
         _db.Entry (ProjectFunction).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool ProjectFunctionExists (int id)
      {
         return _db.ProjectFunctions.Any (r => r.ID == id);
      }

      public bool ProjectFunctionExists (string name)
      {
         return _db.ProjectFunctions.Any (r => r.Name == name);
      }
   }
}
