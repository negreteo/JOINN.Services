using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IMedicalValidationService
   {
      bool MedicalValidationExists (int id);
      bool MedicalValidationExists (string name);
      void AddMedicalValidation (MedicalValidation MedicalValidation);
      IEnumerable<MedicalValidation> GetMedicalValidations ();
      MedicalValidation GetMedicalValidation (int id);
      void UpdateMedicalValidation (MedicalValidation MedicalValidation);
   }
}
