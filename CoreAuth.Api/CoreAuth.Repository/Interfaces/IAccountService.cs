using CoreAuth.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAuth.Repository.Interfaces
{
    public interface IAccountService
    {
        bool SignIn(UserModel user);
        UserInfoModel AuthenticateUser(UserModel userModel);
        string GenerateJSONWebToken(UserInfoModel userInfo);
    }
}
