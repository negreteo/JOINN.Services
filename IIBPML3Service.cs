using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IIBPML3Service
   {
      bool IBPML3Exists (int id);
      bool IBPML3Exists (string name);
      void AddIBPML3 (IBPML3 IBPML3);
      IEnumerable<IBPML3> GetIBPML3s ();
      IBPML3 GetIBPML3 (int id);
      void UpdateIBPML3 (IBPML3 IBPML3);
   }
}
