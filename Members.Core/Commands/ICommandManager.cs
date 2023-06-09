﻿using Members.Core.Observers;

namespace Members.Core.Commands
{
    public interface ICommandManager : IObservable
    {
        bool HasUndo { get; }
        bool HasRedo { get; }

        void Execute(ICommand command);
        void Undo();
        void Redo();
    }
}
