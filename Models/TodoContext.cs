using Microsoft.EntittFrameworkCore;

namespace TodoApi.Models{
    public class TodoContext : DbContext
    {
        public TodoCOntext(DbContextOptions<TOdoContext> options) : base(options) {}

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}