using AppTbd.Outbound.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppTbd.Outbound.Persistence.Adapters;

public class AppTbdDbContext(DbContextOptions<AppTbdDbContext> options) : DbContext(options)
{
    public DbSet<TodoItemEntity> TodoItems { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
}