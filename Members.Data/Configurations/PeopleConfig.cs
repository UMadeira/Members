using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Members.Models.Domain;

namespace Members.Data.Configurations
{
    internal class PersonConfig : ItemConfig<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);

            builder
                .HasMany(e => e.Groups)
                .WithMany(e => e.Users);
        }
    }
}
