using DataNasabah.Models;
using Microsoft.EntityFrameworkCore;

namespace DataNasabah
{
  public class NasabahDbContext : DbContext
  {
    public NasabahDbContext(DbContextOptions<NasabahDbContext> context):base(context) 
    {
      
    }

    public DbSet<Nasabah> Nasabah { get; set; }
    public DbSet<AlamatNasabah> AlamatNasabah { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<AlamatNasabah>()
        .HasOne(_ => _.Nasabah)
        .WithMany(_ => _.AlamatNasabah)
        .HasForeignKey(_ => _.IdNasabah);
    }
  }
}
