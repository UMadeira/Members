using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Core.Commands
{
    public class MacroCommand : ICommand
    {
        private IList<ICommand> Commands { get; } = new List<ICommand>();

        public void Add( ICommand command )
        {
            Commands.Add( command );
        }

        public void Do()
        {
            foreach ( var command in Commands ) 
            {
                command.Do();
            }
        }

        public void Redo() 
        {
            foreach (var command in Commands)
            {
                command.Redo();
            }
        }

        public void Undo()
        {
            foreach (var command in Commands.Reverse() )
            {
                command.Undo();
            }
        }
    }
}
