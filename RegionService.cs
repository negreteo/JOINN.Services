using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class RegionService : IRegionService
   {
      private readonly JOINNDbContext _db;

      public RegionService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddRegion (Region region)
      {
         _db.Add (region);
         _db.SaveChanges ();
      }

      public Region GetRegion (int id)
      {
         return _db.Regions.Find (id);
      }

      public IEnumerable<Region> GetRegions ()
      {
         var regions = _db.Regions
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();

         return regions;
      }

      public void UpdateRegion (Region region)
      {
         _db.Entry (region).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool RegionExists (int id)
      {
         return _db.Regions.Any (r => r.ID == id);
      }

      public bool RegionExists (string name)
      {
         return _db.Regions.Any (r => r.Name == name);
      }
   }
}
