using Members.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersApp.Commands
{
    public class SelectTreeNode : ICommand
    {
        public SelectTreeNode( TreeNode node ) 
        {
            Node = node;
            View = node.TreeView;
        }

        private TreeView View { get; set; }
        private TreeNode Node { get; set; }

        public void Do()
        {
            var node = View.SelectedNode; 
            View.SelectedNode = Node;
            Node = node;
        }

        public void Undo() => Do();

        public void Redo() => Do();

        public void Cancel() { }
    }
}
