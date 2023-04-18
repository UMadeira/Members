using Members.Core.Commands;
using Members.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Members.Core.Patterns;

namespace MembersApp.Commands
{
    public class CreateTreeNodeCommand : ICommand
    {
        public CreateTreeNodeCommand( TreeNodeCollection nodes, Member member ) 
        {
            Nodes = nodes;
            Member = member;

            Node = new TreeNode(member.Name);
            Node.ImageKey = Node.SelectedImageKey = member.GetType().Name;
        }

        public Member Member { get; }
        private TreeNodeCollection Nodes { get; }
        private TreeNode Node { get; }

        public void Do()
        {
            Node.Tag = Member.Subscribe((s, a) => Node.Text = Member.Name);
            Nodes.Add(Node);
        }

        public void Redo() => Do();

        public void Undo()
        {
            var observer = Node.Tag as Observer;
            observer?.Unsubscribe();

            Node.Remove();
        }
    }
}
