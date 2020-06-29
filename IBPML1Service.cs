using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class IBPML1Service : IIBPML1Service
   {
      private readonly JOINNDbContext _db;

      public IBPML1Service (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddIBPML1 (IBPML1 IBPML1)
      {
         _db.Add (IBPML1);
         _db.SaveChanges ();
      }

      public IBPML1 GetIBPML1 (int id)
      {
         return _db.IBPML1.Find (id);
      }

      public IEnumerable<IBPML1> GetIBPML1s ()
      {
         return _db.IBPML1
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateIBPML1 (IBPML1 IBPML1)
      {
         _db.Entry (IBPML1).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool IBPML1Exists (int id)
      {
         return _db.IBPML1.Any (r => r.ID == id);
      }

      public bool IBPML1Exists (string name)
      {
         return _db.IBPML1.Any (r => r.Name == name);
      }
   }
}
