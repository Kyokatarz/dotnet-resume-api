using System.ComponentModel.DataAnnotations;

namespace DotnetResume.Models
{
  public class Resume
  {
    public int ResumeId { get; set; }

    [Required]
    public string ResumeCode { get; set; }

    [Required]
    public string ResumeName { get; set; }

    [Required]
    public bool Deleted { get; set; }
  }
}