using Members.Core.Commands;
using Members.Core.Repositories;

namespace Members.Models.Commands
{
    public class CreateCommand : ICommand
    {
        public CreateCommand( Item item ) 
        { 
            Item = item;
        }

        private Item Item { get; set; }

        public void Do()
        {
            Item.Zombie = false;
        }

        public void Undo()
        {
            Item.Zombie = true;
        }

        public void Redo() => Do();

        public void Cancel() {}
    }
}
