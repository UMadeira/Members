namespace Members.Core.Commands
{
    public interface ICommand
    {
        void Do();
        void Undo();
        void Redo();
    }
}
