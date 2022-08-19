using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        // INICIO - Para SQL Server
        protected readonly IConfiguration Configuration;

        public TodoContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
        // FIN SQL SERVER
        /*public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }*/

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}