using Members.Core.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Core.Commands
{
    public interface ICommand 
    {
        void Do();
        void Undo();
        void Redo();
    }
}
