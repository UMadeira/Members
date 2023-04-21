using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Members.Models.Domain;

namespace Members.Data.Configurations
{
    internal class MemberConfig<T> : ItemConfig<T> where T : Member
    {
        public override void Configure( EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
        }
    }
}
