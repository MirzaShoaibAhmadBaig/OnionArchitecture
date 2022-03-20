using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Contract_Interface
{
   public interface IUser
    {
        List<User> GetAllRepo();

        User GetUserById(long id);

        string AddNewUser(User user);


        string UpdateUser(User user);

        string RemoveUser(long id);



    }
}
