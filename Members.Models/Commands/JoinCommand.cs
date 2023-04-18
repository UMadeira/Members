using Members.Core.Commands;
using Members.Models.Domain;

namespace Members.Models.Commands
{
    public class JoinCommand : ICommand
    {
        public JoinCommand( Group group, Member member ) 
        { 
            Group  = group;
            Member = member;
        }

        private Group Group { get; }
        private Member Member { get; }

        public void Do()
        {
            Group.Members.Add( Member );
        }

        public void Undo()
        {
            Group.Members.Remove( Member );
        }

        public void Redo() => Do();

        public void Cancel() {}
    }
}
