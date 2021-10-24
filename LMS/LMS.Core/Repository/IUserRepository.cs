using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface IUserRepository
    {
        public List<Login> ReturnLogin();
        public bool Register(Login login);
        //public bool UpdateLogin(Login login);
        public bool DeleteLogin(int loginId);
        public Login Authentiaction(Login login);

    }

}
