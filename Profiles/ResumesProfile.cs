using AutoMapper;
using DotnetResume.Dtos;
using DotnetResume.Models;

namespace DotnetResume.Profiles
{
  public class ResumesProfile : Profile
  {

    public ResumesProfile()
    {
      CreateMap<Resume, ResumeReadDto>();
      CreateMap<ResumeCreateDto, Resume>();
    }
  }
}