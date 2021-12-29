using Microsoft.EntityFrameworkCore;
using MyApi.Models;
namespace MyMvc.Models
{
    public class FakeContext : DbContext
    {
        public FakeContext(DbContextOptions<FakeContext> options)
            : base(options)
        {
        }
        public DbSet<Item> TodoItems { get; set; }
        public DbSet<MyApi.Models.Item> TodoItem { get; set; }
    }
}