using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IFinalDecisionService
   {
      bool FinalDecisionExists (int id);
      bool FinalDecisionExists (string name);
      void AddFinalDecision (FinalDecision FinalDecision);
      IEnumerable<FinalDecision> GetFinalDecisions ();
      FinalDecision GetFinalDecision (int id);
      void UpdateFinalDecision (FinalDecision FinalDecision);
   }
}
