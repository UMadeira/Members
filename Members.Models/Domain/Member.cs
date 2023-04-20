using Members.Core.Observers;

namespace Members.Models.Domain
{
    public class Member : Observable
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
    }
}
