namespace Members.Core.Repositories
{
    public interface IFactory
    {
        void Regist( Type type );
        T?  Create<T>( params object?[]? args );
    }
}
