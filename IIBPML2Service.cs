using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IIBPML2Service
   {
      bool IBPML2Exists (int id);
      bool IBPML2Exists (string name);
      void AddIBPML2 (IBPML2 IBPML2);
      IEnumerable<IBPML2> GetIBPML2s ();
      IBPML2 GetIBPML2 (int id);
      void UpdateIBPML2 (IBPML2 IBPML2);
   }
}
