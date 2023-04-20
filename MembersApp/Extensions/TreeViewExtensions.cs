using Members.Core.Observers;

namespace MembersApp.Extensions
{
    internal static class TreeViewExtensions
    {
        public static bool HasSelectedNode( this TreeView treeView )
        {
            return treeView.SelectedNode != null;
        }

        public static bool HasSelectedNodeOfType<T>( this TreeView treeView ) where T : class, IObservable
        {
            return treeView.SelectedNode?.GetSemantic<T>() != null;
        }
    }
}
