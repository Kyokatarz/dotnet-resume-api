using DotnetResume.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetResume.Data
{
  public class ResumeContext : DbContext
  {
    public ResumeContext(DbContextOptions<ResumeContext> opt) : base(opt)
    {

    }

    public DbSet<Resume> Resumes { get; set; }
  }
}