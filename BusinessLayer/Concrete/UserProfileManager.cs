using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<User> repoUser = new Repository<User>();

        public List<User> GetUserByMail(string p)
        {
            return repoUser.List(x => x.Mail == p);
        }
    }
}
