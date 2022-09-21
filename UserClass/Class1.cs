using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using UserClass.Model;

namespace UserClass
{
    public interface IUserModule
    {
        UserTable ValidateUser(string email, string password);

        void RegisterUser(UserTable customer);

        void UpdateUserDetails(string address, string contactNumber, int userId);

        List<PolicyDb> GetAllOrders(int userId);
    }

    public class UserComponent : IUserModule
    {
        public List<PolicyDb> GetAllOrders(int userId)
        {
            throw new NotImplementedException();
        }
        private bool isCustomerNotAvailable(string emailAddress)
        {
            //get the customer with matching email address
            var contxt = new InsuranceDBEntities();
            var user = contxt.UserTables.FirstOrDefault((c) => c.userEmail == emailAddress);
            //if not found return true, else return false. 
            return user == null;
        }
        public void RegisterUser(UserTable user)
        {
            var context = new InsuranceDBEntities(); ;
            if (isCustomerNotAvailable(user.userEmail))
                context.UserTables.Add(user);
            else
                throw new CustomerAlreadyExistsException("This Email Address is already available");
            context.SaveChanges();
        }

        public void UpdateUserDetails(string address, double contactNumber, int userId)
        {
            var context = new InsuranceDBEntities();
            var user = context.UserTables.FirstOrDefault((c) => c.userId == userId);
            if (user == null)
                throw new Exception("Customer does not exist");
            user.userAddress = address;
            user.userContact = (decimal)contactNumber;
            context.SaveChanges();
        }

        public UserTable ValidateUser(string email, string password)
        {
            var context = new InsuranceDBEntities();
            var rec = context.UserTables.Where((c) => c.userEmail == email && c.userPwd == password).SingleOrDefault();
            return rec;
        }
        
        UserTable IUserModule.ValidateUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        //void IUserModule.RegisterUser(UserTable customer)B
        //{
        //    throw new NotImplementedException();
        //}

        void IUserModule.UpdateUserDetails(string address, string contactNumber, int userId)
        {
            throw new NotImplementedException();
        }

        List<PolicyDb> IUserModule.GetAllOrders(int userId)
        {
            throw new NotImplementedException();
        }
    }


    [Serializable]
   public class CustomerAlreadyExistsException : Exception
    {
        public CustomerAlreadyExistsException()
        {
        }

        public CustomerAlreadyExistsException(string message) : base(message)
        {
        }

        public CustomerAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomerAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
    