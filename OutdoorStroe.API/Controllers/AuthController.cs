using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OutdoorStroe.API.Models;

namespace OutdoorStroe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public class AuthenticationRequestBody
        {
            public string? UserName { get; set; }
            public string? Password { get; set; }
        }
        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate(AuthenticationRequestBody authenticationRequestBody)
        {
            var hasher = new PasswordHasher<string>();
            
            var user = ValudateUserCredentials(authenticationRequestBody.UserName,
                                               authenticationRequestBody.Password);
        }

        private User ValudateUserCredentials(string? userName, string? password)
        {
            throw new NotImplementedException();
        }
    }
}
