using System.Collections.Generic;
using System.Threading.Tasks;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IRegionService
   {
      IEnumerable<Region> GetRegions ();
      Region GetRegion (int id);
      void AddRegion (Region region);
      void UpdateRegion (Region region);
      bool RegionExists (int id);
      bool RegionExists (string name);
   }
}
