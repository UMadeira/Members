namespace Members.Core.Observers
{
    public interface IObservable
    {
        event EventHandler? Notify;
    }
}
