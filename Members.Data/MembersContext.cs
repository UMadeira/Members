using Microsoft.EntityFrameworkCore;
using Members.Data.Configurations;

namespace Members.Data
{
    public class MembersContext : DbContext
    {
        protected override void OnConfiguring( DbContextOptionsBuilder builder )
        {
            base.OnConfiguring(builder);

            builder
                .UseLazyLoadingProxies()
                .UseSqlServer(
                    @"data source=(LocalDb)\MSSQLLocalDB;" +
                    @"initial catalog=Members2023;" +
                    @"integrated security=True; " +
                    @"MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration( new PersonConfig() );
            modelBuilder.ApplyConfiguration( new GroupConfig() );
        }
    }
}