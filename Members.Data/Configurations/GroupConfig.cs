using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Members.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Members.Data.Configurations
{
    internal class GroupConfig : MemberConfig<Group>
    {
        public override void Configure( EntityTypeBuilder<Group> builder )
        {
            base.Configure(builder);

            builder
                .HasMany(e => e.Members)
                .WithMany();
        }
    }
}
