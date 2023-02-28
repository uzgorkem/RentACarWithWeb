using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
        public User GetById(int UserId)
        {
            return _userDal.Get(p => p.UserId == UserId);
        }
    }
}
