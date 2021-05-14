using System.Collections.Generic;
using AutoMapper;
using DotnetResume.Data;
using DotnetResume.Dtos;
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
    private readonly IMapper _mapper;

    public ResumesController(IResumeRepo repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    //GET api/resumes
    [HttpGet]
    public ActionResult<IEnumerable<ResumeReadDto>> GetAllResumes()
    {
      var resumes = _repository.GetAllResumes();
      return Ok(_mapper.Map<IEnumerable<ResumeReadDto>>(resumes));
    }

    //GET api/resumes/{id}
    [HttpGet("{id}")]
    public ActionResult<ResumeReadDto> GetResumeById(int id)
    {
      var resume = _repository.GetResumeById(id);
      if (resume != null)
      {
        return Ok(_mapper.Map<ResumeReadDto>(resume));
      }

      return NotFound();
    }
  }
}