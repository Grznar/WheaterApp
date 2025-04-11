using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WheaterApp.Server.Data.IRepositories;
using WheaterApp.Server.Models;
using WheaterApp.Server.Models.VMModels;

namespace WheaterApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthController(
            IUnitOfWork unitOfWork,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingUser = await _userManager.FindByEmailAsync(user.Email);
            if (existingUser != null)
            {
                return BadRequest(new { StatusMessage = "User already exists", StatusCode = 400 });
            }

            var newUser = new ApplicationUser()
            {
                UserName = user.Email,
                Email = user.Email,
                EmailConfirmed = true
            };

            
            var result_ = await _userManager.CreateAsync(newUser, user.Password);
            if (!result_.Succeeded)
            {
                return BadRequest(new { StatusMessage = "Can’t create this user", Errors = result_.Errors, StatusCode = 400 });
            }

            await _signInManager.SignInAsync(newUser, isPersistent: false);
            return Ok(new { StatusMessage = "User created successfully", StatusCode = 200 });
        }
    }
}
