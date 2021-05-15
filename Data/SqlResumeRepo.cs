using System;
using System.Collections.Generic;
using System.Linq;
using DotnetResume.Models;

namespace DotnetResume.Data
{
  public class SqlResumeRepo : IResumeRepo
  {
    private readonly ResumeContext _context;

    public SqlResumeRepo(ResumeContext context)
    {
      _context = context;
    }

    public void CreateResume(Resume newResume)
    {
      if (newResume == null) throw new ArgumentNullException(nameof(newResume));

      _context.Resumes.Add(newResume);


    }

    public void DeleteResume(Resume resume)
    {
      if (resume == null)
      {
        throw new ArgumentNullException(nameof(resume));
      }
      _context.Resumes.Remove(resume);
    }

    public IEnumerable<Resume> GetAllResumes()
    {
      return _context.Resumes.ToList();
    }

    public Resume GetResumeById(int id)
    {
      return _context.Resumes.FirstOrDefault(p => p.ResumeId == id);
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }

    public void UpdateResume(Resume newResume)
    {

    }
  }
}