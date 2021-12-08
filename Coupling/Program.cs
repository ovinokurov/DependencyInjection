using System;

namespace Coupling
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataAccess dal = new DataAccess();
            IBusiness biz = new Business(dal);
            var userInterface = new UserInterface(biz);

        }
    }

    public class UserInterface
    {
        private readonly IBusiness _business;
        public UserInterface(IBusiness business)
        {
            business = _business;
            GetData();
        }
        public void GetData()
        {
            Console.Write("Enter your username: ");
            var userName = Console.ReadLine();

            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            //old no injection
            //IDataAccess dal = new DataAccess();
            //IBusiness business = new Business(dal);
            //business.SignUp(userName, password);

            //new injection
            _business.SignUp(userName, password);
        }
    } 
}
