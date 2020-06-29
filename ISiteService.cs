using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface ISiteService
   {
      bool SiteExists (int id);
      bool SiteExists (string name);
      void AddSite (Site Site);
      IEnumerable<Site> GetSites ();
      Site GetSite (int id);
      void UpdateSite (Site Site);
   }
}
