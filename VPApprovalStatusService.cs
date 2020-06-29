using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class VPApprovalStatusService : IVPApprovalStatusService
   {
      private readonly JOINNDbContext _db;

      public VPApprovalStatusService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddVPApprovalStatus (VPApprovalStatus VPApprovalStatus)
      {
         _db.Add (VPApprovalStatus);
         _db.SaveChanges ();
      }

      public VPApprovalStatus GetVPApprovalStatus (int id)
      {
         return _db.VPApprovalStatus.Find (id);
      }

      public IEnumerable<VPApprovalStatus> GetVPApprovalStatuses ()
      {
         return _db.VPApprovalStatus
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateVPApprovalStatus (VPApprovalStatus VPApprovalStatus)
      {
         _db.Entry (VPApprovalStatus).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool VPApprovalStatusExists (int id)
      {
         return _db.VPApprovalStatus.Any (r => r.ID == id);
      }

      public bool VPApprovalStatusExists (string name)
      {
         return _db.VPApprovalStatus.Any (r => r.Name == name);
      }
   }
}
