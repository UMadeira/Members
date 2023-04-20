namespace Members.Core.Repositories
{
    public abstract class Item
    {
        public int Id { get; set; }
        public bool Zombie { get; set; } = false;
        public byte[] TimeStamp { get; set; }
    }
}
