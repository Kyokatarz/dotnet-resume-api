using System.Collections.Generic;
using DotnetResume.Data;
using DotnetResume.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetResume.Controllers
{
  //  api/resumes 
  [Route("api/resumes")]
  [ApiController]
  public class ResumesController : ControllerBase
  {
    private readonly IResumeRepo _repository;

    public ResumesController(IResumeRepo repository)
    {
      _repository = repository;
    }
    //private readonly MockResumeRepo _repository = new MockResumeRepo();
    //GET api/resumes
    [HttpGet]
    public ActionResult<IEnumerable<Resume>> GetAllResumes()
    {
      var resumes = _repository.GetAllResumes();
      return Ok(resumes);
    }

    //GET api/resumes/{id}
    [HttpGet("{id}")]
    public ActionResult<Resume> GetResumeById(int id)
    {
      var resume = _repository.GetResumeById(id);
      return Ok(resume);
    }
  }
}