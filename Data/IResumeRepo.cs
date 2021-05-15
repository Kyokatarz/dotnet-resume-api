using System.Collections.Generic;
using DotnetResume.Models;

namespace DotnetResume.Data
{
  public interface IResumeRepo
  {
    bool SaveChanges();
    IEnumerable<Resume> GetAllResumes();
    Resume GetResumeById(int id);
    void CreateResume(Resume newResume);
    void UpdateResume(Resume newResume);

    void DeleteResume(Resume newResume);
  }
}