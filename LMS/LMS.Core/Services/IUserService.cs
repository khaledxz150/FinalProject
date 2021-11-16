using LMS.Core.DTO;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface IUserService
    {
        public List<Login> ReturnLogin();
        public bool Register(Login login);
        public bool DeleteLogin(int loginId);
        public string Authentiaction(LoginDTO login);

    }

}
