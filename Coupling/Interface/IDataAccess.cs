using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    public interface IDataAccess
    {
        void Store(string userName, string password);
    }
}
