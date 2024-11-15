using Microsoft.EntityFrameworkCore;

namespace WebApplicationPractice.Todo.Entity
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoItem> Todos { get; set; } = null!;
    }
}
