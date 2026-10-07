using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SecurityApp.Controllers
{
    public class AccountController : Controller
    {
        UserManager<IdentityUser> um;
        SignInManager<IdentityUser> sm;

        public AccountController(UserManager<IdentityUser> u,
            SignInManager<IdentityUser> s)
        {
            um = u; sm = s;
        }

        public IActionResult Register() => View();
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Register(string email, string password)
        {
            var u = new IdentityUser { UserName = email, Email = email };
            var r = await um.CreateAsync(u, password);

            if (r.Succeeded)
                return RedirectToAction("Login");

            ViewBag.Error = string.Join(", ",
                r.Errors.Select(x => x.Description));

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var r = await sm.PasswordSignInAsync(email, password, false, false);

            if (r.Succeeded)
                return RedirectToAction("Index", "Home");

            ViewBag.Error = "Invalid Login";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await sm.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}