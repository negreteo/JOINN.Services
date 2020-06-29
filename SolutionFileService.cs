using System;
using System.Collections.Generic;
using System.Linq;
using JOINN.Data;
using JOINN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JOINN.Services
{
   public class SolutionFileService : ISolutionFileService
   {
      private readonly JOINNDbContext _db;

      public SolutionFileService (JOINNDbContext _db)
      {
         this._db = _db;
      }

      public void AddSolutionFile (SolutionFile SolutionFile)
      {
         _db.Add (SolutionFile);
         _db.SaveChanges ();
      }

      public SolutionFile GetSolutionFile (int id)
      {
         return _db.SolutionFiles.Find (id);
      }

      public IEnumerable<SolutionFile> GetSolutionFiles ()
      {
         return _db.SolutionFiles
            .OrderBy (r => r.AzureBlobFileName)
            .AsNoTracking ()
            .ToList ();
      }

      public void UpdateSolutionFile (SolutionFile SolutionFile)
      {
         _db.Entry (SolutionFile).State = EntityState.Modified;
         _db.SaveChanges ();
      }

      public bool SolutionFileExists (int id)
      {
         return _db.SolutionFiles.Any (r => r.ID == id);
      }

      public bool SolutionFileExists (string name)
      {
         return _db.SolutionFiles.Any (r => r.AzureBlobFileName == name);
      }
   }
}
