using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IBenefitTypeService
   {
      bool BenefitTypeExists (int id);
      bool BenefitTypeExists (string name);
      void AddBenefitType (BenefitType BenefitType);
      IEnumerable<BenefitType> GetBenefitTypes ();
      BenefitType GetBenefitType (int id);
      void UpdateBenefitType (BenefitType BenefitType);
   }
}
