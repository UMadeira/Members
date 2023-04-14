using System.Diagnostics;

namespace Members.Core.Patterns
{
    public class Observable : IObservable
    {
        public event EventHandler? Notify;

        protected void InvokeNotify( EventArgs? args = null )
        {
            Notify?.Invoke( this, args ?? EventArgs.Empty );
        }
    }
}
