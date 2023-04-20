﻿using Auth.Data.Classes;

namespace Members.Core.Repositories
{
    public class Factory
    {
        public Factory()
            : this(typeof(User), typeof(Group), typeof(Permission))
        {
        }

        public Factory(params Type[] types)
        {
            Constructs = new List<Type>(types);
        }

        private static IList<Type> Constructs { get; set; } = new List<Type>();

        public T? Create<T>(params object?[]? args)
        {
            var type = typeof(T);

            if (!Constructs.Contains(type)) return Cast<T>(null);
            return Cast<T>(Activator.CreateInstance(type, args));
        }

        public static T? Cast<T>(object? obj)
        {
            return (T?)obj;
        }
    }
}
