using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szkeduel2000.Domain
{
    public class User
    {
        int userId;
        string userEmail;
        string nickname;
        string password;
        public User()
        {
        }

        public User(int userId, string userEmail, string nickname,string password)
        {
            this.userId = userId;
            this.userEmail = userEmail;
            this.nickname = nickname;
            this.password = password;
        }
    }
}
