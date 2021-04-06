using CoreAuth.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAuth.Repository.Interfaces
{
    public interface IHelperService
    {
        string GenerateJWT(PayloadModel model);
    }
}
