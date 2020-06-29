using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class LocationService : ILocationService
   {
      private readonly JOINNDbContext _db;

      public LocationService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddLocation (Location Location)
      {
         _db.Add (Location);
         _db.SaveChanges ();
      }

      public Location GetLocation (int id)
      {
         return _db.Locations.Find (id);
      }

      public IEnumerable<Location> GetLocations ()
      {
         return _db.Locations
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateLocation (Location Location)
      {
         _db.Entry (Location).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool LocationExists (int id)
      {
         return _db.Locations.Any (r => r.ID == id);
      }

      public bool LocationExists (string name)
      {
         return _db.Locations.Any (r => r.Name == name);
      }
   }
}
