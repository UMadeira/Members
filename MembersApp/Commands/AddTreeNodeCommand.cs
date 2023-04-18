using Members.Core.Commands;
using Members.Models.Domain;
using MembersApp.Extensions;

namespace MembersApp.Commands
{
    internal class AddTreeNodeCommand : ICommand
    {
        public AddTreeNodeCommand( TreeNodeCollection nodes, Member member )
        { 
            Nodes  = nodes;

            Node = new TreeNode( member.Name );
            Node.ImageKey = Node.SelectedImageKey = member.GetType().Name;
            Node.Subscribe( member, (s, a) => Node.Text = member.Name );
        }

        public TreeNodeCollection Nodes { get; set; }
        public TreeNode Node { get; set; }

        public void Do()
        {
            Nodes.Add( Node );
        }

        public void Undo()
        {
            Nodes.Remove( Node );
        }

        public void Redo() => Do();

        public void Cancel() 
        {
            Node.Unsubscribe();
        }
    }
}
