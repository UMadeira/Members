using Members.Core.Commands;

namespace MembersApp.Commands
{
    internal class RemoveTreeNodeCommand : ICommand
    {
        public RemoveTreeNodeCommand( TreeNode node ) 
        { 
            Node = node;
            Nodes = node.Parent?.Nodes ?? node.TreeView.Nodes;
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

        public void Cancel() { }
    }
}
