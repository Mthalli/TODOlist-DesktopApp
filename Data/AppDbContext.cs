using TODOlist_forms.Models;
using Microsoft.EntityFrameworkCore;
namespace TODOlist_forms.Data;

public class AppDbContext : DbContext
{
    public DbSet<TodoTask> TodoTasks { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todoapp.db");
    }
}