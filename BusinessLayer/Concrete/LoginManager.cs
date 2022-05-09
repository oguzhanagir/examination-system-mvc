using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LoginManager
    {
        Repository<User> repoUser = new Repository<User>();
        public int UserAddBL(User p)
        {
            return repoUser.Insert(p);
        }
    }
}
