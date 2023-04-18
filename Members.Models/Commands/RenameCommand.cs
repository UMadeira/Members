using Members.Core.Commands;
using Members.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Models.Commands
{
    public class RenameCommand : ICommand
    {
        public RenameCommand( Member member, string name ) 
        {
            Member = member;
            Name   = name;
        }

        private Member Member { get; set; }
        public string Name { get; set; }

        public void Do()
        {
            var aux = Member.Name;
            Member.Name = Name;
            Name = aux;
        }

        public void Undo() => Do();

        public void Redo() => Do();
    }
}
