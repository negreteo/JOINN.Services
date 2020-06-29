using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class BenefitUnitService : IBenefitUnitService
   {
      private readonly JOINNDbContext _db;

      public BenefitUnitService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddBenefitUnit (BenefitUnit BenefitUnit)
      {
         _db.Add (BenefitUnit);
         _db.SaveChanges ();
      }

      public BenefitUnit GetBenefitUnit (int id)
      {
         return _db.BenefitUnits.Find (id);
      }

      public IEnumerable<BenefitUnit> GetBenefitUnits ()
      {
         return _db.BenefitUnits
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateBenefitUnit (BenefitUnit BenefitUnit)
      {
         _db.Entry (BenefitUnit).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool BenefitUnitExists (int id)
      {
         return _db.BenefitUnits.Any (r => r.ID == id);
      }

      public bool BenefitUnitExists (string name)
      {
         return _db.BenefitUnits.Any (r => r.Name == name);
      }
   }
}
