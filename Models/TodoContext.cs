using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TotoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}