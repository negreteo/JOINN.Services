using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface ILocationService
   {
      bool LocationExists (int id);
      bool LocationExists (string name);
      void AddLocation (Location Location);
      IEnumerable<Location> GetLocations ();
      Location GetLocation (int id);
      void UpdateLocation (Location Location);
   }
}
