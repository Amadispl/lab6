using Microsoft.EntityFrameworkCore;

namespace MyApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Item> TodoItems { get; set; }
    }
}