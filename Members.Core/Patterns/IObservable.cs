namespace Members.Core.Patterns
{
    public interface IObservable
    {
        event EventHandler? Notify;
    }
}
