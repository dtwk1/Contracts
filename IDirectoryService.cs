



namespace Contracts
{
    using System.Collections.Generic;

    public interface IDirectoryService<T>
    {

        IEnumerable<T> Collection { get; }


        void Refresh();

    }


    public interface IDirectoryService
    {

        IEnumerable<object> Collection { get; }


        void Refresh();

    }
}
