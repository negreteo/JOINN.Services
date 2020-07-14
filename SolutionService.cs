using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using JOINN.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class SolutionService : ISolutionService
   {
      private readonly JOINNDbContext _db;

      public SolutionService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddSolution (Solution Solution)
      {
         _db.Add (Solution);
         _db.SaveChanges ();
      }

      public Solution GetSolution (int id)
      {
         return _db.Solutions.Find (id);
      }

      public IEnumerable<SolutionView> GetSolutions ()
      {
         List<SolutionView> ret;

         var q = from s in _db.Solutions.AsNoTracking ()
         join pt in _db.ProjectTypes.AsNoTracking () on s.ProjectType.ID equals pt.ID
         join l1 in _db.IBPML1.AsNoTracking () on s.IBPML1.ID equals l1.ID
         join l2 in _db.IBPML2.AsNoTracking () on s.IBPML2.ID equals l2.ID
         join l3 in _db.IBPML3.AsNoTracking () on s.IBPML3.ID equals l3.ID
         join ps in _db.ProjectStatus.AsNoTracking () on s.ProjectStatus.ID equals ps.ID
         join ig in _db.ITGuidelines.AsNoTracking () on s.ITGuideLine.ID equals ig.ID
         join pf in _db.ProjectFunctions.AsNoTracking () on s.ProjectFunction.ID equals pf.ID
         join bt in _db.BenefitTypes.AsNoTracking () on s.BenefitType.ID equals bt.ID
         join bu in _db.BenefitUnits.AsNoTracking () on s.BenefitUnit.ID equals bu.ID
         join cc in _db.CostCategories.AsNoTracking () on s.CostCategory.ID equals cc.ID
         join l in _db.Locations.AsNoTracking () on s.Location.ID equals l.ID
         join r in _db.Regions.AsNoTracking () on s.Region.ID equals r.ID
         join mv in _db.MedicalValidations.AsNoTracking () on s.MedicalValidation.ID equals mv.ID
         join ss in _db.SolutionStatus.AsNoTracking () on s.SolutionStatus.ID equals ss.ID
         join fd in _db.FinalDecisions.AsNoTracking () on s.FinalDecision.ID equals fd.ID
         join sw in _db.SubWorkStreams.AsNoTracking () on s.SubWorkStream.ID equals sw.ID
         select new { s, pt, l1, l2, l3, ps, ig, pf, bt, bu, cc, l, r, mv, ss, fd, sw };

         ret = (from t in q.ToList () select new SolutionView ()
         {
            ID = t.s.ID,
               ProjectType = t.pt.Name,
               IBPML1 = t.l1.Name,
               IBPML2 = t.l2.Name,
               IBPML3 = t.l3.Name,
               InCMDB = t.s.InCMDB,
               Title = t.s.Title,
               Description = t.s.Description,
               TryingToSolve = t.s.TryingToSolve,
               Version = t.s.Version,
               ProjectStatus = t.ps.Name,
               ITGuideline = t.ig.Name,
               ProjectFunction = t.pf.Name,
               FunctionRemarks = t.s.FunctionRemarks,
               BenefitType = t.bt.Name,
               BenefitComments = t.s.BenefitComments,
               BenefitUnit = t.bu.Name,
               BenefitValue = t.s.BenefitValue,
               InvestmentCost = t.s.InvestmentCost,
               RealizedAnnualSavings = t.s.RealizedAnnualSavings,
               CostCategory = t.cc.Name,
               Location = t.l.Name,
               Region = t.r.Name,
               Site = t.s.Site,
               ProductOwner = t.s.ProductOwner,
               ProcessOwner = t.s.ProcessOwner,
               HasDocumentation = t.s.HasDocumentation,
               MedicalValidation = t.mv.Name,
               SolutionStatus = t.ss.Name,
               FinalDecision = t.fd.Name,
               Comments = t.s.Comments,
               SubWorkStream = t.sw.Name,
               IsPackageReady = t.s.IsPackageReady,
               CreatedBy = t.s.CreatedBy,
               CreatedDate = t.s.CreatedDate,
               UpdatedBy = t.s.UpdatedBy,
               LastUpdate = t.s.LastUpdate
         }).ToList ();

         return ret;
      }

      public void UpdateSolution (Solution Solution)
      {
         _db.Entry (Solution).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool SolutionExists (int id)
      {
         return _db.Solutions.Any (r => r.ID == id);
      }

      public bool SolutionExists (string name)
      {
         return _db.Solutions.Any (r => r.Title == name);
      }

   }
}
