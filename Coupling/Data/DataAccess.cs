using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    public class DataAccess : IDataAccess
    {
        public void Store(string userName, string password)
        {
            //write the data to the db
        }
    }
}
