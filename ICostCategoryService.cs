using System.Collections.Generic;
using JOINN.Data.Models;

namespace JOINN.Services
{
   public interface ICostCategoryService
   {
      bool CostCategoryExists (int id);
      bool CostCategoryExists (string name);
      void AddCostCategory (CostCategory CostCategory);
      IEnumerable<CostCategory> GetCostCategories ();
      CostCategory GetCostCategory (int id);
      void UpdateCostCategory (CostCategory CostCategory);
   }
}
