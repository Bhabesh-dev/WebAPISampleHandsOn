using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPISampleHandsOn.Models;

namespace WebAPISampleHandsOn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public ApplicationUserController( UserManager<ApplicationUser> userManager , SignInManager<ApplicationUser> signInManager )
        {
            this._userManager = userManager;
            this._signInManager = signInManager;

        }


        [HttpPost]
        [Route("Register")]
        public async Task<object> PostApplicationUser(ApplicationUserModel model)
        {
            var appuser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email =model.Email,
                FullName =model.FullName
            };

            try
            {
                var result = await _userManager.CreateAsync(appuser, model.Password);
                return Ok(result);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}