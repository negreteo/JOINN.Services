using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class BenefitTypeService : IBenefitTypeService
   {
      private readonly JOINNDbContext _db;

      public BenefitTypeService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddBenefitType (BenefitType BenefitType)
      {
         _db.Add (BenefitType);
         _db.SaveChanges ();
      }

      public BenefitType GetBenefitType (int id)
      {
         return _db.BenefitTypes.Find (id);
      }

      public IEnumerable<BenefitType> GetBenefitTypes ()
      {
         return _db.BenefitTypes
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateBenefitType (BenefitType BenefitType)
      {
         _db.Entry (BenefitType).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool BenefitTypeExists (int id)
      {
         return _db.BenefitTypes.Any (r => r.ID == id);
      }

      public bool BenefitTypeExists (string name)
      {
         return _db.BenefitTypes.Any (r => r.Name == name);
      }
   }
}
