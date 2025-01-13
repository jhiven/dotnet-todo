using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data;

public class TodoContext(DbContextOptions<TodoContext> options) : DbContext(options)
{
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}
