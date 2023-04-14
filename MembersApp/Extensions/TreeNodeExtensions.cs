using Members.Core.Patterns;

namespace MembersApp.Extensions
{
    internal static class TreeNodeExtensions
    {
        public static T? GetSemantic<T>( this TreeNode node ) where T : Observable
        {
            var observer = node.Tag as Observer;
            return observer?.Observable as T;
        }
    }
}
