using Microsoft.EntityFrameworkCore;
using Members.Data.Configurations;
using Members.Models.Domain;

namespace Members.Data
{
    public class MembersContext : DbContext
    {
        public MembersContext() 
        { 
        }

        public MembersContext( DbContextOptions<MembersContext> options ) : base(options) 
        { 
        }

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

            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());

            //modelBuilder.Entity<Group>().HasKey(e => e.Id);
            //modelBuilder.Entity<Group>().Property(e => e.Id).UseIdentityColumn();
            //modelBuilder.Entity<Group>().Property(e => e.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            //modelBuilder.Entity<Group>().HasMany(e => e.Members).WithMany();

            //modelBuilder.Entity<Person>().HasKey(e => e.Id);
            //modelBuilder.Entity<Person>().Property(e => e.Id).UseIdentityColumn();
            //modelBuilder.Entity<Person>().Property(e => e.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();

        }
    }
}