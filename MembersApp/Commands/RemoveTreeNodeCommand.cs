using Members.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersApp.Commands
{
    public class RemoveTreeNodeCommand : ICommand
    {
        public RemoveTreeNodeCommand(TreeNodeCollection nodes, TreeNode node)
        {
            Nodes = nodes;
            Node = node;
        }

        private TreeNodeCollection Nodes { get; }
        private TreeNode Node { get; }

        public void Do()
        {
            Node.Remove();
        }

        public void Undo()
        {
            Nodes.Add(Node);
        }

        public void Redo() => Do();
    }
}
