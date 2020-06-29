using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IApprovalDecisionService
   {
      bool ApprovalDecisionExists (int id);
      bool ApprovalDecisionExists (string name);
      void AddApprovalDecision (ApprovalDecision ApprovalDecision);
      IEnumerable<ApprovalDecision> GetApprovalDecisions ();
      ApprovalDecision GetApprovalDecision (int id);
      void UpdateApprovalDecision (ApprovalDecision ApprovalDecision);
   }
}
