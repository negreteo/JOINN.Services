using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IVPApprovalService
   {
      bool VPApprovalExists (int id);
      void AddVPApproval (VPApproval VPApproval);
      IEnumerable<VPApproval> GetVPApprovals ();
      VPApproval GetVPApproval (int id);
      void UpdateVPApproval (VPApproval VPApproval);
   }
}
