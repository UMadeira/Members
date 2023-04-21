using Members.Core.Commands;
using Members.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
