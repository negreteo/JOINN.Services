using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class ApprovalDecisionService : IApprovalDecisionService
   {
      private readonly JOINNDbContext _db;

      public ApprovalDecisionService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddApprovalDecision (ApprovalDecision ApprovalDecision)
      {
         _db.Add (ApprovalDecision);
         _db.SaveChanges ();
      }

      public ApprovalDecision GetApprovalDecision (int id)
      {
         return _db.ApprovalDecisions.Find (id);
      }

      public IEnumerable<ApprovalDecision> GetApprovalDecisions ()
      {
         return _db.ApprovalDecisions
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateApprovalDecision (ApprovalDecision ApprovalDecision)
      {
         _db.Entry (ApprovalDecision).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool ApprovalDecisionExists (int id)
      {
         return _db.ApprovalDecisions.Any (r => r.ID == id);
      }

      public bool ApprovalDecisionExists (string name)
      {
         return _db.ApprovalDecisions.Any (r => r.Name == name);
      }
   }
}
