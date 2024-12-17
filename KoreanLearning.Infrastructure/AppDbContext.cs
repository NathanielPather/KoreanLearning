using KoreanLearning.Core.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
     public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Vocabulary> Vocabularies { get; set; }
    public DbSet<Characters> Characters { get; set; }
    public DbSet<Practice> Practice { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Practice>();
            //.HasMany(p => p.Characters);

        //SeedDatabase(modelBuilder);
    }

    private void SeedDatabase(ModelBuilder modelBuilder)
    {
        //var vocabularies = LoadExcelData.LoadExcelDataM("C:\\Users\\Nathaniel.Pather\\Downloads\\hangul_pronunciation.xlsx");

        //int id = 1;
        //foreach (var vocab in vocabularies)
        //{
        //    vocab.Id = id++;
        //    modelBuilder.Entity<Characters>().HasData(vocab);
        //}
    }
}
