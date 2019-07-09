using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    using System.Windows.Input;

    public interface IOpenCommand
    {
        ICommand OpenCommand { get; set; }
    }
}
