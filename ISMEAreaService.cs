using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface ISMEAreaService
   {
      bool SMEAreaExists (int id);
      bool SMEAreaExists (string name);
      void AddSMEArea (SMEArea SMEArea);
      IEnumerable<SMEArea> GetSMEAreas ();
      SMEArea GetSMEArea (int id);
      void UpdateSMEArea (SMEArea SMEArea);
   }
}
