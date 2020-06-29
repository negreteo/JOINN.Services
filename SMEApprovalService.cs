using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class SMEApprovalService : ISMEApprovalService
   {
      private readonly JOINNDbContext _db;

      public SMEApprovalService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddSMEApproval (SMEApproval SMEApproval)
      {
         _db.Add (SMEApproval);
         _db.SaveChanges ();
      }

      public SMEApproval GetSMEApproval (int id)
      {
         return _db.SMEApprovals.Find (id);
      }

      public IEnumerable<SMEApproval> GetSMEApprovals ()
      {
         return _db.SMEApprovals
            .OrderBy (r => r.Area)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateSMEApproval (SMEApproval SMEApproval)
      {
         _db.Entry (SMEApproval).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool SMEApprovalExists (int id)
      {
         return _db.SMEApprovals.Any (r => r.ID == id);
      }
   }
}
