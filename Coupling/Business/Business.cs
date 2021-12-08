using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    public class Business : IBusiness
    {
        private readonly IDataAccess _dataAccess;

        public Business(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void SignUp(string userName, string password)
        {
            //validation

            //old no injection
            //var dataAccess = new DataAccess();
            //dataAccess.Store(userName, password);

            //new injection
            _dataAccess.Store(userName, password);
        }
    }
}
