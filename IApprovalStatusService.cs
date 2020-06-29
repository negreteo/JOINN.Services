using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IApprovalStatusService
   {
      bool ApprovalStatusExists (int id);
      bool ApprovalStatusExists (string name);
      void AddApprovalStatus (ApprovalStatus ApprovalStatus);
      IEnumerable<ApprovalStatus> GetApprovalStatus ();
      ApprovalStatus GetApprovalStatus (int id);
      void UpdateApprovalStatus (ApprovalStatus ApprovalStatus);
   }
}
