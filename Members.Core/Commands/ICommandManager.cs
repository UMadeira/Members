using Members.Core.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
