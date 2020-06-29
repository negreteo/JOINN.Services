using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class VPApprovalService : IVPApprovalService
   {
      private readonly JOINNDbContext _db;

      public VPApprovalService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddVPApproval (VPApproval VPApproval)
      {
         _db.Add (VPApproval);
         _db.SaveChanges ();
      }

      public VPApproval GetVPApproval (int id)
      {
         return _db.VPApprovals.Find (id);
      }

      public IEnumerable<VPApproval> GetVPApprovals ()
      {
         return _db.VPApprovals
            .OrderBy (r => r.Area)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateVPApproval (VPApproval VPApproval)
      {
         _db.Entry (VPApproval).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool VPApprovalExists (int id)
      {
         return _db.VPApprovals.Any (r => r.ID == id);
      }
   }
}
