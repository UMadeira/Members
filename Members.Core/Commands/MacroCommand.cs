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

        public MacroCommand( params ICommand[] commands ) 
        {
            foreach (var command in commands)
                Commands.Add(command);       
        }

        public void Execute( ICommand command ) 
        { 
            Commands.Add( command );
        }

        public void Do()
        {
            foreach ( ICommand command in Commands )
                command.Do();
        }

        public void Undo()
        {
            foreach ( var command in Commands.Reverse() )
                command.Undo();
        }

        public void Redo() => Do();

        public void Cancel()
        {
            foreach ( var command in Commands )
                command.Cancel();
        }
    }
}
