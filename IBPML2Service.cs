using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class IBPML2Service : IIBPML2Service
   {
      private readonly JOINNDbContext _db;

      public IBPML2Service (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddIBPML2 (IBPML2 IBPML2)
      {
         _db.Add (IBPML2);
         _db.SaveChanges ();
      }

      public IBPML2 GetIBPML2 (int id)
      {
         return _db.IBPML2.Find (id);
      }

      public IEnumerable<IBPML2> GetIBPML2s ()
      {
         return _db.IBPML2
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateIBPML2 (IBPML2 IBPML2)
      {
         _db.Entry (IBPML2).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool IBPML2Exists (int id)
      {
         return _db.IBPML2.Any (r => r.ID == id);
      }

      public bool IBPML2Exists (string name)
      {
         return _db.IBPML2.Any (r => r.Name == name);
      }
   }
}
