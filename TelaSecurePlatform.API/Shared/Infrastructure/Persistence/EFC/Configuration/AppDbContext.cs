using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;
using TelaSecurePlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

namespace TelaSecurePlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        /*
        builder.Entity<FavoriteSource>().HasKey(f => f.Id);
        builder.Entity<FavoriteSource>().Property(f => f.Id)
            .IsRequired().ValueGeneratedOnAdd();
        builder.Entity<FavoriteSource>().Property(f => f.NewsApiKey)
            .IsRequired();
        builder.Entity<FavoriteSource>().Property(f => f.SourceId)
            .IsRequired();
        */
        builder.UseSnakeCaseNamingConvention();
    }
}
