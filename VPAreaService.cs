using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class VPAreaService : IVPAreaService
   {
      private readonly JOINNDbContext _db;

      public VPAreaService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddVPArea (VPArea VPArea)
      {
         _db.Add (VPArea);
         _db.SaveChanges ();
      }

      public VPArea GetVPArea (int id)
      {
         return _db.VPAreas.Find (id);
      }

      public IEnumerable<VPArea> GetVPAreas ()
      {
         return _db.VPAreas
            .OrderBy (r => r.Area)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateVPArea (VPArea VPArea)
      {
         _db.Entry (VPArea).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool VPAreaExists (int id)
      {
         return _db.VPAreas.Any (r => r.ID == id);
      }

      public bool VPAreaExists (string name)
      {
         return _db.VPAreas.Any (r => r.Area == name);
      }
   }
}
