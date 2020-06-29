using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IVPAreaService
   {
      bool VPAreaExists (int id);
      bool VPAreaExists (string name);
      void AddVPArea (VPArea VPArea);
      IEnumerable<VPArea> GetVPAreas ();
      VPArea GetVPArea (int id);
      void UpdateVPArea (VPArea VPArea);
   }
}
