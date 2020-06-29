using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class IBPML3Service : IIBPML3Service
   {
      private readonly JOINNDbContext _db;

      public IBPML3Service (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddIBPML3 (IBPML3 IBPML3)
      {
         _db.Add (IBPML3);
         _db.SaveChanges ();
      }

      public IBPML3 GetIBPML3 (int id)
      {
         return _db.IBPML3.Find (id);
      }

      public IEnumerable<IBPML3> GetIBPML3s ()
      {
         return _db.IBPML3
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateIBPML3 (IBPML3 IBPML3)
      {
         _db.Entry (IBPML3).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool IBPML3Exists (int id)
      {
         return _db.IBPML3.Any (r => r.ID == id);
      }

      public bool IBPML3Exists (string name)
      {
         return _db.IBPML3.Any (r => r.Name == name);
      }
   }
}
