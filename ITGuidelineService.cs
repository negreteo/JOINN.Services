using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class ITGuidelineService : IITGuidelineService
   {
      private readonly JOINNDbContext _db;

      public ITGuidelineService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddITGuideline (ITGuideline ITGuideline)
      {
         _db.Add (ITGuideline);
         _db.SaveChanges ();
      }

      public ITGuideline GetITGuideline (int id)
      {
         return _db.ITGuidelines.Find (id);
      }

      public IEnumerable<ITGuideline> GetITGuidelines ()
      {
         return _db.ITGuidelines
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateITGuideline (ITGuideline ITGuideline)
      {
         _db.Entry (ITGuideline).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool ITGuidelineExists (int id)
      {
         return _db.ITGuidelines.Any (r => r.ID == id);
      }

      public bool ITGuidelineExists (string name)
      {
         return _db.ITGuidelines.Any (r => r.Name == name);
      }
   }
}
