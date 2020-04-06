using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AudionClient.Models
{
    public class AudionClientContext : DbContext
    {
      public AudionClientContext(DbContextOptions options) : base(options) { }
    }
}