using CoreAuth.Model;
using CoreAuth.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CoreAuth.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AuthController(IConfiguration config, IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public IActionResult SignIn([FromForm] UserModel userModel)
        {
            var user = _accountService.AuthenticateUser(userModel);
            IActionResult Response = Unauthorized();
            if (user != null)
            {
                var tokenStr = _accountService.GenerateJSONWebToken(user);
                Response = Ok(new { token = tokenStr });
            }
            return Response;
        }

        [Authorize]
        [HttpPost]
        public string Test()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claim = identity.Claims.ToList();
            var username = claim[0].Value.ToString();
            var role = claim[3].Value.ToString();
            return $"Welcome {username}, Role : {role}";
        }
    }
}
