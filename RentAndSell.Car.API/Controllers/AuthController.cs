using Microsoft.AspNetCore.Mvc;
using RentAndSell.Car.API.Models;

namespace RentAndSell.Car.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("Login")]
        public ActionResult Login(LoginViewModel model)
        {
            LoginResultViewModel loginResult = new LoginResultViewModel();
            loginResult.BasicAuth = "Basic acb123xyz";
            loginResult.IsLogin = true;
            loginResult.ErrorMessage = "";

            return Ok(loginResult);
        }
    }
}
