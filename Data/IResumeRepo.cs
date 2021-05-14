using System.Collections.Generic;
using DotnetResume.Models;

namespace DotnetResume.Data
{
  public interface IResumeRepo
  {
    IEnumerable<Resume> GetAllResumes();
    Resume GetResumeById(int id);
  }
}