using RjWebsite.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RjWebsite.DAL
{
    public class ChoreContext : DbContext
    {

        public ChoreContext() : base("ChoreContext")
        {
        }

        public DbSet<Roommate> Roommates { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public DbSet<Week> Weeks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}