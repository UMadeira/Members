namespace Members.DTOs
{
    public class Group : Member
    {
        public IEnumerable<Person>? Members { get; set; }
    }
}
