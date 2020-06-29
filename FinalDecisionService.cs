using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class FinalDecisionService : IFinalDecisionService
   {
      private readonly JOINNDbContext _db;

      public FinalDecisionService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddFinalDecision (FinalDecision FinalDecision)
      {
         _db.Add (FinalDecision);
         _db.SaveChanges ();
      }

      public FinalDecision GetFinalDecision (int id)
      {
         return _db.FinalDecisions.Find (id);
      }

      public IEnumerable<FinalDecision> GetFinalDecisions ()
      {
         return _db.FinalDecisions
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateFinalDecision (FinalDecision FinalDecision)
      {
         _db.Entry (FinalDecision).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool FinalDecisionExists (int id)
      {
         return _db.FinalDecisions.Any (r => r.ID == id);
      }

      public bool FinalDecisionExists (string name)
      {
         return _db.FinalDecisions.Any (r => r.Name == name);
      }
   }
}
