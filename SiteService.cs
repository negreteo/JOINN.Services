using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class SiteService : ISiteService
   {
      private readonly JOINNDbContext _db;

      public SiteService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddSite (Site Site)
      {
         _db.Add (Site);
         _db.SaveChanges ();
      }

      public Site GetSite (int id)
      {
         return _db.Sites.Find (id);
      }

      public IEnumerable<Site> GetSites ()
      {
         return _db.Sites
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateSite (Site Site)
      {
         _db.Entry (Site).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool SiteExists (int id)
      {
         return _db.Sites.Any (r => r.ID == id);
      }

      public bool SiteExists (string name)
      {
         return _db.Sites.Any (r => r.Name == name);
      }
   }
}
