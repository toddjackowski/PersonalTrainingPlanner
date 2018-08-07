using Microsoft.EntityFrameworkCore;
using PersonalTrainingPlanner.Model;

namespace PersonalTrainingPlanner.DataLayer
{
    public class PersonalTrainingPlannerContext : DbContext
    {
        public PersonalTrainingPlannerContext(DbContextOptions<PersonalTrainingPlannerContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
