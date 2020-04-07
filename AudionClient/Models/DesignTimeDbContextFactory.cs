using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AudionClient.Models
{
  public class AudionClientFactory : IDesignTimeDbContextFactory<AudionClientContext>
  {

    AudionClientContext IDesignTimeDbContextFactory<AudionClientContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<AudionClientContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new AudionClientContext(builder.Options);
    }
  }
}