using DomainLayer.Model;
using RepositoryLayer;
using ServiceLayer.Services.Contract_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implemantation
{
   public class UserService : IUser
    {
        private readonly AppDBContext _dBContext;

        public UserService(AppDBContext dBContext)
        {
            this._dBContext = dBContext;
        }
        public string AddNewUser(User user)
        {
            this._dBContext.tblusers.Add(user);
            this._dBContext.SaveChanges();
            return "Success";         
                
                }

        public List<User> GetAllRepo()
        {

            try
            {
                return this._dBContext.tblusers.ToList();

            }
            catch (Exception ex)
            {

                return null;

            }
        }

        public User GetUserById(long id)
        {
            return this._dBContext.tblusers.Find(id);
        }

        public string RemoveUser(long id)
        {
            var user = this._dBContext.tblusers.Find(id);
            if(user!=null)
             {
                this._dBContext.tblusers.Remove(user);
                
                
            }
            return "User Remove Successfully";
        }

        public string UpdateUser(User user)
        {
            var userValue = this._dBContext.tblusers.Find(user.UserId);
            if(userValue== null)
            {
                return "User Not Found";


            }
            User newuser = new User();

            user.UserPhone = userValue.UserPhone;
            user.UserName = userValue.UserName;
            user.UserAddress = userValue.UserAddress;
            user.UserEmailId = userValue.UserEmailId;
            user.UpdatedDate = userValue.UpdatedDate;
            this._dBContext.SaveChanges();

            return "User Update Successfully";

        }
    }
}
