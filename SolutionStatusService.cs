using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class SolutionStatusService : ISolutionStatusService
   {
      private readonly JOINNDbContext _db;

      public SolutionStatusService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddSolutionStatus (SolutionStatus SolutionStatus)
      {
         _db.Add (SolutionStatus);
         _db.SaveChanges ();
      }

      public SolutionStatus GetSolutionStatus (int id)
      {
         return _db.SolutionStatus.Find (id);
      }

      public IEnumerable<SolutionStatus> GetSolutionStatus ()
      {
         return _db.SolutionStatus
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateSolutionStatus (SolutionStatus SolutionStatus)
      {
         _db.Entry (SolutionStatus).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool SolutionStatusExists (int id)
      {
         return _db.SolutionStatus.Any (r => r.ID == id);
      }

      public bool SolutionStatusExists (string name)
      {
         return _db.SolutionStatus.Any (r => r.Name == name);
      }
   }
}
