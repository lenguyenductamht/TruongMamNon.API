using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TruongMamNon.BackendApi.Data.EF;

namespace Data.EF
{
    public class TruongMamNonDbContextFactory : IDesignTimeDbContextFactory<TruongMamNonDbContext>
    {
        public TruongMamNonDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("TruongMamNonConnection");

            var optionsBuilder = new DbContextOptionsBuilder<TruongMamNonDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TruongMamNonDbContext(optionsBuilder.Options);
        }
    }
}