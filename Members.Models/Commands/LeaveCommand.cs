using Members.Core.Commands;
using Members.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Models.Commands
{
    public class LeaveCommand : ICommand
    {
        public LeaveCommand(Group group, Member member)
        {
            Group = group;
            Member = member;
        }

        private Group Group { get; }
        private Member Member { get; }

        public void Do()
        {
            Group.Members.Remove(Member);
        }

        public void Undo()
        {
            Group.Members.Add(Member);
        }

        public void Redo() => Do();

        public void Cancel() { }
    }
}
