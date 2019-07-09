
namespace Contracts
{
    public interface ICreate<T>
    {
        T Create();
    }

    public interface ICreate
    {
        object  Create();
    }
}
