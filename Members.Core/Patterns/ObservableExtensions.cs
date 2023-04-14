namespace Members.Core.Patterns
{
    public static class ObservableExtensions
    {
        public static IObserver Subscribe( this IObservable observable, EventHandler handler )
        {
            var observer = new Observer( handler );
            observer.Subscribe( observable );
            return observer;
        }
    }
}
