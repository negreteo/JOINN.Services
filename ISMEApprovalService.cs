using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface ISMEApprovalService
   {
      bool SMEApprovalExists (int id);
      void AddSMEApproval (SMEApproval SMEApproval);
      IEnumerable<SMEApproval> GetSMEApprovals ();
      SMEApproval GetSMEApproval (int id);
      void UpdateSMEApproval (SMEApproval SMEApproval);
   }
}
