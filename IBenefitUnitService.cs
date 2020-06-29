using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IBenefitUnitService
   {
      bool BenefitUnitExists (int id);
      bool BenefitUnitExists (string name);
      void AddBenefitUnit (BenefitUnit BenefitUnit);
      IEnumerable<BenefitUnit> GetBenefitUnits ();
      BenefitUnit GetBenefitUnit (int id);
      void UpdateBenefitUnit (BenefitUnit BenefitUnit);
   }
}
