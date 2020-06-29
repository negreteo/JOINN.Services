using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class SubWorkStreamService : ISubWorkStreamService
   {
      private readonly JOINNDbContext _db;

      public SubWorkStreamService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddSubWorkStream (SubWorkStream SubWorkStream)
      {
         _db.Add (SubWorkStream);
         _db.SaveChanges ();
      }

      public SubWorkStream GetSubWorkStream (int id)
      {
         return _db.SubWorkStreams.Find (id);
      }

      public IEnumerable<SubWorkStream> GetSubWorkStreams ()
      {
         return _db.SubWorkStreams
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateSubWorkStream (SubWorkStream SubWorkStream)
      {
         _db.Entry (SubWorkStream).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool SubWorkStreamExists (int id)
      {
         return _db.SubWorkStreams.Any (r => r.ID == id);
      }

      public bool SubWorkStreamExists (string name)
      {
         return _db.SubWorkStreams.Any (r => r.Name == name);
      }
   }
}
