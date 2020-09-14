using CleanArch.Domin.Models.Course;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        #region construtor

        public UniversityDBContext(DbContextOptions<UniversityDBContext> options):base(options)
        {
            
        }

        #endregion

        public DbSet<Course> Courses { get; set; }
    }
}