using System.Diagnostics;

namespace Members.Core.Patterns
{
    public class Observer : IObserver
    {
        private EventHandler Handler { get; set; }

        public Observer( EventHandler handler )
        {
            Handler = handler;
        }

        public IObservable? Observable { get; set; }

        public void Subscribe( IObservable observable ) 
        {
            Observable  = observable;
            Observable.Notify += Handler;
        }

        public void Unsubscribe()
        {
            if ( Observable != null ) Observable.Notify -= Handler;
        }

    }
}
