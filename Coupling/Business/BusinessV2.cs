using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    public class BusinessV2 : IBusiness
    {
        public void SignUp(string userName, string password)
        {
            //validation
            var dataAccess = new DataAccess();
            dataAccess.Store(userName, password);
        }
    }
}
