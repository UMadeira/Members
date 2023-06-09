﻿using Members.Core.Observers;

namespace MembersApp.Extensions
{
    internal static class TreeNodeExtensions
    {
        public static T? GetSemantic<T>( this TreeNode node ) where T : class, IObservable
        {
            var observer = node.Tag as IObserver;
            return observer?.Observable as T;
        }

        public static void Subscribe( this TreeNode node, IObservable observable, EventHandler handler ) 
        {
            var observer = new Observer( handler );
            observer.Subscribe(observable);
            node.Tag = observer;
        }

        public static void Unsubscribe( this TreeNode node ) 
        {
            var observer = node?.Tag as IObserver;
            observer?.Unsubscribe();
        }
    }
}
