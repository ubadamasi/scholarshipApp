using Microsoft.EntityFrameworkCore;
using ScholarshipApp.API.Models;

namespace ScholarshipApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}