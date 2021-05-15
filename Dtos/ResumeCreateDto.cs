using System.ComponentModel.DataAnnotations;

namespace DotnetResume.Dtos
{
  public class ResumeCreateDto
  {
    [Required]
    public string ResumeCode { get; set; }
    [Required]
    public string ResumeName { get; set; }

    public bool Deleted { get; set; }

  }
}