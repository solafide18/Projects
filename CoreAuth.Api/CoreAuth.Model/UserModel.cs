using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAuth.Model
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class UserInfoModel : UserModel
    {
        public string Role { get; set; }
        public string EmailAddress { get; set; }
        public int MinuteExpirated { get; set; }
    }
}
