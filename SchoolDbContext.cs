using Microsoft.EntityFrameworkCore;
using System;

public class SchoolDbContext : DbContext
{
	public DbSet<Teacher> Teacher { get; set; }
	public DbSet<Pupil> Pupils { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
		optionsBuilder.UseSqlServer(@"Server=ANA;Database=SchoolApp;Trusted_Connection=True;");
    }
}
