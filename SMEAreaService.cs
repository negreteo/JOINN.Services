using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class SMEAreaService : ISMEAreaService
   {
      private readonly JOINNDbContext _db;

      public SMEAreaService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddSMEArea (SMEArea SMEArea)
      {
         _db.Add (SMEArea);
         _db.SaveChanges ();
      }

      public SMEArea GetSMEArea (int id)
      {
         return _db.SMEAreas.Find (id);
      }

      public IEnumerable<SMEArea> GetSMEAreas ()
      {
         return _db.SMEAreas
            .OrderBy (r => r.Area)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateSMEArea (SMEArea SMEArea)
      {
         _db.Entry (SMEArea).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool SMEAreaExists (int id)
      {
         return _db.SMEAreas.Any (r => r.ID == id);
      }

      public bool SMEAreaExists (string name)
      {
         return _db.SMEAreas.Any (r => r.Area == name);
      }
   }
}
