using Members.Core.Commands;
using Members.Models.Domain;

namespace Members.Models.Commands
{
    public class DeleteCommand : ICommand
    {
        public DeleteCommand( Member member ) 
        { 
            Member = member;
        }

        private Member Member { get; }

        public void Do() => Member.Zombie = true;

        public void Undo() => Member.Zombie = false;

        public void Redo() => Do();

        public void Cancel()
        {
        }
    }
}
