using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Members.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Members.Data.Configurations
{
    internal class PersonConfig : MemberConfig<Person>
    {
        public override void Configure( EntityTypeBuilder<Person> builder )
        {
            base.Configure(builder);
        }
    }
}
