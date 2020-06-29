using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface IVPApprovalStatusService
   {
      bool VPApprovalStatusExists (int id);
      bool VPApprovalStatusExists (string name);
      void AddVPApprovalStatus (VPApprovalStatus VPApprovalStatus);
      IEnumerable<VPApprovalStatus> GetVPApprovalStatuses ();
      VPApprovalStatus GetVPApprovalStatus (int id);
      void UpdateVPApprovalStatus (VPApprovalStatus VPApprovalStatus);
   }
}
