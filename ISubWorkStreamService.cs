using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface ISubWorkStreamService
   {
      bool SubWorkStreamExists (int id);
      bool SubWorkStreamExists (string name);
      void AddSubWorkStream (SubWorkStream SubWorkStream);
      IEnumerable<SubWorkStream> GetSubWorkStreams ();
      SubWorkStream GetSubWorkStream (int id);
      void UpdateSubWorkStream (SubWorkStream SubWorkStream);
   }
}
