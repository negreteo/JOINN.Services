using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IIBPML1Service
   {
      bool IBPML1Exists (int id);
      bool IBPML1Exists (string name);
      void AddIBPML1 (IBPML1 IBPML1);
      IEnumerable<IBPML1> GetIBPML1s ();
      IBPML1 GetIBPML1 (int id);
      void UpdateIBPML1 (IBPML1 IBPML1);
   }
}
