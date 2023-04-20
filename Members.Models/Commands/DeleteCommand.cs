using Members.Core.Commands;
using Members.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Models.Commands
{
    public class DeleteCommand : ICommand
    {
        public DeleteCommand( Member member ) 
        { 
            Member = member;
        }

        private Member Member { get; }

        public void Do()
        {
        }

        public void Undo()
        {
        }

        public void Redo()
        {
        }

        public void Cancel()
        {
        }
    }
}
