

namespace Contracts
{

    //public interface IId
    //{
    //    object Id { get; }
    //}

    public interface IFileService<T> //where T:IId
    {
        T Load(string fileName);

        void Save(T t);

    }

    public interface IFileService
    {
        object Load(string fileName);

        void Save(object t);

    }
}
