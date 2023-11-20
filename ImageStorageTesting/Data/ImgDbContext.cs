using ImageStorageTesting.Models;

using Microsoft.EntityFrameworkCore;

namespace ImageStorageTesting.Data;

public class ImgDbContext : DbContext
{
    public ImgDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Profile> Profiles { get; set; }
}
