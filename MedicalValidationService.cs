using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class MedicalValidationService : IMedicalValidationService
   {
      private readonly JOINNDbContext _db;

      public MedicalValidationService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddMedicalValidation (MedicalValidation MedicalValidation)
      {
         _db.Add (MedicalValidation);
         _db.SaveChanges ();
      }

      public MedicalValidation GetMedicalValidation (int id)
      {
         return _db.MedicalValidations.Find (id);
      }

      public IEnumerable<MedicalValidation> GetMedicalValidations ()
      {
         return _db.MedicalValidations
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateMedicalValidation (MedicalValidation MedicalValidation)
      {
         _db.Entry (MedicalValidation).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool MedicalValidationExists (int id)
      {
         return _db.MedicalValidations.Any (r => r.ID == id);
      }

      public bool MedicalValidationExists (string name)
      {
         return _db.MedicalValidations.Any (r => r.Name == name);
      }
   }
}
