using Members.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersApp.Commands
{
    internal class RemoveTreeNodeCommand : ICommand
    {
        public RemoveTreeNodeCommand( TreeNode node ) 
        { 
            Node = node;
            Nodes = node.Nodes;
        }

        private TreeNodeCollection Nodes { get; set; }

        private TreeNode Node { get; set; }

        public void Do()
        {
            Node.Remove();
        }

        public void Undo()
        {
            Nodes.Add( Node );
        }

        public void Redo() => Do();
    }
}
