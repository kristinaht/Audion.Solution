using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AudionClient.Models
{
    public class AudionClientContext : IdentityDbContext<ApplicationUser>
    {
      public AudionClientContext(DbContextOptions options) : base(options) { }
    }
}