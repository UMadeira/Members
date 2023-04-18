using Members.Core.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersApp.Extensions
{
    internal static class TreeViewExtensions
    {
        public static bool HasSelectedNode( this TreeView treeView )
        {
            return treeView.SelectedNode != null;
        }

        public static bool HasSelectedNodeOfType<T>( this TreeView treeView ) where T : Observable
        {
            return treeView.SelectedNode?.GetSemantic<T>() != null;
        }
    }
}
