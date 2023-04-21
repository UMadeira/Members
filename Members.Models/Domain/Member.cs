using Members.Core.Observers;
using Members.Core.Repositories;

namespace Members.Models.Domain
{
    public abstract class Member : Item, IObservable
    {
        private string _name = string.Empty;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                InvokeNotify();
            }
        }

        #region IObservable

        public event EventHandler? Notify;
        protected void InvokeNotify(EventArgs? args = null)
        {
            Notify?.Invoke(this, args ?? EventArgs.Empty);
        }
        
        #endregion
    }
}
