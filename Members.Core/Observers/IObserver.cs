namespace Members.Core.Observers
{
    public interface IObserver
    {
        IObservable? Observable { get; }

        void Subscribe( IObservable observable );
        void Unsubscribe();
    }
}
