using System.Collections.Generic;
using DotnetResume.Models;

namespace DotnetResume.Data
{
  public class SqlResumeRepo : IResumeRepo
  {
    public IEnumerable<Resume> GetAllResumes()
    {
      throw new System.NotImplementedException();
    }

    public Resume GetResumeById(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}