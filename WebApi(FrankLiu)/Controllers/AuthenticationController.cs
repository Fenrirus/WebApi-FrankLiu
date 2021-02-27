using Microsoft.AspNetCore.Mvc;
using WebApiFrankLiu.TokenAuthentication;

namespace WebApiFrankLiu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ITokenManager tokenManager;

        public AuthenticationController(ITokenManager tokenManager)
        {
            this.tokenManager = tokenManager;
        }

        public IActionResult Authenticate(string user, string pwd)
        {
            if (tokenManager.Authenticate(user, pwd))
            {
                return Ok(new { Token = tokenManager.GenerateToken() });
            }
            else
            {
                ModelState.AddModelError("Unauthorize", "You are not authorized");
                return Unauthorized(ModelState);
            }
        }
    }
}