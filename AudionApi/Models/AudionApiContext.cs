using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AudionApi.Models
{
  public class AudionApiContext : DbContext
  {
    public AudionApiContext(DbContextOptions<AudionApiContext> options)
      : base(options)
    {

    }

    public DbSet<Response> Responses { get; set; }
    public DbSet<Question> Questions { get; set; }

    // protected override void OnModelCreating(ModelBuilder builder)(ModelBuilder builder)
    // {
      
    // }
  }
}