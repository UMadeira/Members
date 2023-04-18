using Members.Core.Patterns;

namespace Members.Core.Commands
{
    public class CommandManager : Observable, ICommandManager
    {
        private IList<ICommand> Commands { get; } = new List<ICommand>();

        private int _position = -1;
        private int Position 
        {
            get => _position;
            set
            {
                _position = value;
                InvokeNotify();
            }
        }

        public bool HasUndo => Position > -1;

        public bool HasRedo => Position < Commands.Count - 1;

        public void Execute(ICommand command)
        {
            if ( HasRedo )
            {
                for ( int i = Commands.Count - 1; i > Position; i-- )
                {
                    Commands[i].Cancel();
                    Commands.RemoveAt(i);
                }
            }

            Commands.Add(command);
            command.Do();
            Position++;
        }

        public void Undo()
        {
            if ( ! HasUndo ) return;
            Commands[Position--].Undo();
        }

        public void Redo()
        {
            if ( ! HasRedo ) return;
            Commands[++Position].Redo();
        }
    }
}
