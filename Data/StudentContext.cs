using Microsoft.EntityFrameworkCore;
using MyTestDeploy.Models;

namespace MyTestDeploy.Data
{
    public class StudentContext:DbContext
    {

        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}
