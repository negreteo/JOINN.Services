using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class CostCategoryService : ICostCategoryService
   {
      private readonly JOINNDbContext _db;

      public CostCategoryService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddCostCategory (CostCategory CostCategory)
      {
         _db.Add (CostCategory);
         _db.SaveChanges ();
      }

      public CostCategory GetCostCategory (int id)
      {
         return _db.CostCategories.Find (id);
      }

      public IEnumerable<CostCategory> GetCostCategories ()
      {
         return _db.CostCategories
            .OrderBy (r => r.Name)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateCostCategory (CostCategory CostCategory)
      {
         _db.Entry (CostCategory).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool CostCategoryExists (int id)
      {
         return _db.CostCategories.Any (r => r.ID == id);
      }

      public bool CostCategoryExists (string name)
      {
         return _db.CostCategories.Any (r => r.Name == name);
      }

   }
}
