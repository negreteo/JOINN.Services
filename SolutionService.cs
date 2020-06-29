using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class SolutionService : ISolutionService
   {
      private readonly JOINNDbContext _db;

      public SolutionService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddSolution (Solution Solution)
      {
         _db.Add (Solution);
         _db.SaveChanges ();
      }

      public Solution GetSolution (int id)
      {
         return _db.Solutions.Find (id);
      }

      public IEnumerable<Solution> GetSolutions ()
      {
         return _db.Solutions
            .OrderBy (r => r.Title)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateSolution (Solution Solution)
      {
         _db.Entry (Solution).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool SolutionExists (int id)
      {
         return _db.Solutions.Any (r => r.ID == id);
      }

      public bool SolutionExists (string name)
      {
         return _db.Solutions.Any (r => r.Title == name);
      }
   }
}
