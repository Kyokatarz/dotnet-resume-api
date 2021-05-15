using System.Collections.Generic;
using DotnetResume.Models;

namespace DotnetResume.Data
{
  public class MockResumeRepo : IResumeRepo
  {
    public void CreateResume(Resume newResume)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteResume(Resume newResume)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Resume> GetAllResumes()
    {
      var resumes = new List<Resume>{
        new Resume { ResumeId = 0, ResumeCode = "F1", ResumeName = "FakeApplicant1", Deleted = false },
        new Resume { ResumeId = 1, ResumeCode = "F2", ResumeName = "FakeApplicant2", Deleted = true },
        new Resume { ResumeId = 2, ResumeCode = "F3", ResumeName = "FakeApplicant3", Deleted = false },
      };

      return resumes;
    }

    public Resume GetResumeById(int id)
    {
      return new Resume { ResumeId = 0, ResumeCode = "A1", ResumeName = "Applicant1", Deleted = false };
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateResume(Resume newResume)
    {
      throw new System.NotImplementedException();
    }
  }
}