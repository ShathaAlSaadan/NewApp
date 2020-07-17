using Microsoft.EntityFrameworkCore;
using NewApp.API.Models;

namespace NewApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option):base(option){}

        public DbSet<Value> Values { get; set; }
    }
}