
namespace Members.Core.Repositories
{
    public class Factory : IFactory
    {
        private IList<Type> Constructs { get; set; } = new List<Type>();

        public Factory( params Type[] types )
        {
            Constructs = new List<Type>(types);
        }

        public void Regist( Type type ) 
        {
            if (Constructs.Contains(type)) return;
            Constructs.Add(type);
        }

        public T? Create<T>(params object?[]? args)
        {
            var type = typeof(T);

            if ( ! Constructs.Contains( type ) ) return Cast<T>(null);
            return Cast<T>( Activator.CreateInstance( type, args ) );
        }

        public static T? Cast<T>(object? obj)
        {
            return (T?)obj;
        }
    }
}
