using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class ApprovalStatusService : IApprovalStatusService
   {
      private readonly JOINNDbContext _db;

      public ApprovalStatusService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddApprovalStatus (ApprovalStatus ApprovalStatus)
      {
         _db.Add (ApprovalStatus);
         _db.SaveChanges ();
      }

      public ApprovalStatus GetApprovalStatus (int id)
      {
         return _db.ApprovalStatus.Find (id);
      }

      public IEnumerable<ApprovalStatus> GetApprovalStatus ()
      {
         return _db.ApprovalStatus
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateApprovalStatus (ApprovalStatus ApprovalStatus)
      {
         _db.Entry (ApprovalStatus).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool ApprovalStatusExists (int id)
      {
         return _db.ApprovalStatus.Any (r => r.ID == id);
      }

      public bool ApprovalStatusExists (string name)
      {
         return _db.ApprovalStatus.Any (r => r.Name == name);
      }
   }
}
