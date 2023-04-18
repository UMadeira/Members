using Members.Core.Commands;
using Members.Models.Domain;

namespace Members.Models.Commands
{
    public class RenameMemberCommand : ICommand
    {
        private Member Member { get; set; }

        private string Name { get; set; }

        public RenameMemberCommand(Member member, string name)
        {
            Member = member;
            Name   = name;
        }

        public void Do()
        {
            var name = Member.Name;
            Member.Name = Name;
            Name = name;
        }

        public void Undo() => Do();

        public void Redo() => Do();
    }
}
