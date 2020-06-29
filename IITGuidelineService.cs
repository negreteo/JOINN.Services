using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IITGuidelineService
   {
      bool ITGuidelineExists (int id);
      bool ITGuidelineExists (string name);
      void AddITGuideline (ITGuideline ITGuideline);
      IEnumerable<ITGuideline> GetITGuidelines ();
      ITGuideline GetITGuideline (int id);
      void UpdateITGuideline (ITGuideline ITGuideline);
   }
}
