using Members.Core.Commands;
using Members.Models.Domain;
using MembersApp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MembersApp.Commands
{
    internal class AddTreeNodeCommand : ICommand
    {
        /*
            var node = nodes.Add(member.Name);
            node.ImageKey = node.SelectedImageKey = member.GetType().Name;

            node.Subscribe(member, (s, a) => node.Text = member.Name);

         */
        public AddTreeNodeCommand( TreeNodeCollection nodes, Member member )
        { 
            Nodes  = nodes;
            Member = member;
        }

        public TreeNodeCollection Nodes { get; set; }
        public TreeNode Node { get; set; }
        public Member Member { get; set; }

        public void Do()
        {
            Node = Nodes.Add(Member.Name);
            Node.ImageKey = Node.SelectedImageKey = Member.GetType().Name;

            Node.Subscribe( Member, (s, a) => Node.Text = Member.Name);
        }

        public void Undo()
        {
            Nodes.Remove(Node);
            Node.Unsubscribe();
        }

        public void Redo() => Do();
    }
}
