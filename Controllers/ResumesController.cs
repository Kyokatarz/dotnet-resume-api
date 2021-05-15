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
    //Get all resumes
    [HttpGet]
    public ActionResult<IEnumerable<ResumeReadDto>> GetAllResumes()
    {
      var resumes = _repository.GetAllResumes();
      return Ok(_mapper.Map<IEnumerable<ResumeReadDto>>(resumes));
    }

    //GET api/resumes/{id}
    //Get a resume by id
    [HttpGet("{id}", Name = "GetResumeById")]
    public ActionResult<ResumeReadDto> GetResumeById(int id)
    {
      var resume = _repository.GetResumeById(id);
      if (resume != null)
      {
        return Ok(_mapper.Map<ResumeReadDto>(resume));
      }

      return NotFound();
    }

    //POST api/resumes
    //Create new resume
    [HttpPost]
    public ActionResult<ResumeReadDto> CreateResume(ResumeCreateDto dto)
    {
      var resumeModel = _mapper.Map<Resume>(dto);
      _repository.CreateResume(resumeModel);
      _repository.SaveChanges();

      var resumeReadDto = _mapper.Map<ResumeReadDto>(resumeModel);

      return CreatedAtRoute(nameof(GetResumeById), new { Id = resumeReadDto.ResumeId }, resumeReadDto);
    }

    //PUT api/resumes/{id}
    //Update resume with id
    [HttpPut("{id}")]
    public ActionResult UpdateResume(int id, ResumeUpdateDto dto)
    {
      var resumeModelFromRepo = _repository.GetResumeById(id);
      if (resumeModelFromRepo == null) return NotFound();

      _mapper.Map(dto, resumeModelFromRepo);

      _repository.UpdateResume(resumeModelFromRepo);

      _repository.SaveChanges();

      return NoContent();
    }

    //Delete api/resumes/{id}
    //Delete resume with id
    [HttpDelete("{id}")]

    public ActionResult DeleteResume(int id)
    {
      var resumeModelFromRepo = _repository.GetResumeById(id);
      if (resumeModelFromRepo == null)
      {
        return NotFound();
      }

      _repository.DeleteResume(resumeModelFromRepo);
      _repository.SaveChanges();
      return NoContent();
    }
  }
}