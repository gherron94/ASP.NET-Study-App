using System;
using Microsoft.EntityFrameworkCore;
using StudyApp.Models;

namespace StudyApp.Data
{
  public class StudyContext : DbContext
  {

    public DbSet<Week> Weeks
    {get; set;}
    public DbSet<StudyData> StudyData
    {get; set;}

    public StudyContext(DbContextOptions<StudyContext> options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Week>().ToTable("Week");
      modelBuilder.Entity<StudyData>().ToTable("StudyData");

    }

  }
}