namespace Members.Core.Patterns
{
    public interface IObserver
    {
        IObservable? Observable { get; }

        void Subscribe( IObservable observable );
        void Unsubscribe();
    }
}
