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
    public IEnumerable<Resume> GetAllResumes()
    {
      return _context.Resumes.ToList();
    }

    public Resume GetResumeById(int id)
    {
      return _context.Resumes.FirstOrDefault(p => p.ResumeId == id);
    }
  }
}