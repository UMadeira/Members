using Members.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersApp.Commands
{
    public class AddTreeNodeCommand : ICommand
    {
        public AddTreeNodeCommand( TreeNodeCollection nodes, TreeNode node ) 
        { 
            Nodes = nodes;
            Node  = node; 
        }

        private TreeNodeCollection Nodes { get; }
        private TreeNode Node { get; }

        public void Do()
        {
            Nodes.Add( Node );
        }

        public void Undo()
        {
            Node.Remove();
        }
        public void Redo() => Do();
    }
}
