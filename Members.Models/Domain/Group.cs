namespace Members.Models.Domain
{
    public class Group : Member
    {
        public IList<Member> Members { get; set; } = new List<Member>();

    }
}
