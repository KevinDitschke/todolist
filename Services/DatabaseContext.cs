using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Services;

public sealed class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options ) : base(options)
    {
    }
    
    public DbSet<ToDoEntry> ToDoEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDoEntry>().ToTable("ToDoEntries");
    }
}