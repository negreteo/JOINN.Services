using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class SolutionTypeService : ISolutionTypeService
   {
      private readonly JOINNDbContext _db;

      public SolutionTypeService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddSolutionType (SolutionType SolutionType)
      {
         _db.Add (SolutionType);
         _db.SaveChanges ();
      }

      public SolutionType GetSolutionType (int id)
      {
         return _db.SolutionTypes.Find (id);
      }

      public IEnumerable<SolutionType> GetSolutionTypes ()
      {
         return _db.SolutionTypes
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateSolutionType (SolutionType SolutionType)
      {
         _db.Entry (SolutionType).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool SolutionTypeExists (int id)
      {
         return _db.SolutionTypes.Any (r => r.ID == id);
      }

      public bool SolutionTypeExists (string name)
      {
         return _db.SolutionTypes.Any (r => r.Name == name);
      }
   }
}
