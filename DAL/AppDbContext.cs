using System.Data.Entity;
using DAL.Entities;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
            //base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Quiz> Quizes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }

    }
}
