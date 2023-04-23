namespace Members.Models.Domain
{
    public class Group : Member
    {
        public virtual IList<Person> Members { get; set; } = new List<Person>();
    }
}
