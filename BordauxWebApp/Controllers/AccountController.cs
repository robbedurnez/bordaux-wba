using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BordauxWebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using BordauxLib.Entities;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using Microsoft.AspNetCore.Authorization;
using BordauxWebApp.Data;
using System.Collections.Generic;

namespace BordauxWebApp.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly BordauxContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IHostingEnvironment hostingEnvironemnt, BordauxContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _hostingEnvironment = hostingEnvironemnt;
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Title = "Register";

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterVM model)
        {
            if (ModelState.IsValid)
            {
                string fileName = null;

                if (_userManager.FindByEmailAsync(model.Email) != null)
                {
                    ModelState.AddModelError("Email", "There is already an account with this email address.");
                }

                if (model.ProfileImage != null)
                {
                    var uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img");
                    fileName = $"{Guid.NewGuid()}_{model.ProfileImage.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    await model.ProfileImage.CopyToAsync(new FileStream(filePath, FileMode.Create));
                }

                var account = new ApplicationUser { FirstName = model.FirstName, LastName = model.LastName, UserName = model.Email, Email = model.Email, ProfilePicturePath = fileName };
                var result = await _userManager.CreateAsync(account, model.Password);

                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(account.Email);
                    await _userManager.AddToRoleAsync(user, "User");
                    await _signInManager.SignInAsync(account, isPersistent: false);
                    TempData["UserRegistered"] = $"You are now registered. Welcome {model.FirstName}!";

                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.Title = "Log in";

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginVM model, string redirectUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(redirectUrl))
                    {
                        return LocalRedirect(redirectUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError(string.Empty, "Login failed");
            }

            ViewBag.Title = "Log in";

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult BecomePromotor()
        {
            ViewBag.Title = "Upgrade to promotor";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpgradeToPromotor()
        {
            var user = await GetCurrentUserAsync();
            var result = await _userManager.AddToRoleAsync(user, "Promotor");

            if (result.Succeeded)
            {
                _context.Promotors.Add(new Promotor()
                {
                    Id = user.Id,
                    Email = user.Email,
                    Events = new List<Event>()
                });
                _context.SaveChanges();

                TempData["UpgradedToPromotor"] = "You are now a Promotor.";

                return RedirectToAction("Overview");
            }

            TempData["UpgradeFailed"] = "Upgrade to promotor failed.";

            return RedirectToAction("Overview");
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var user = await GetCurrentUserAsync();
            var model = new AccountUpdateVM()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                ProfilePicturePath = user.ProfilePicturePath
            };

            ViewBag.Title = "Edit account";

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AccountUpdateVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                string fileName = null;

                if (model.ProfileImage != null)
                {
                    var folder = Path.Combine(_hostingEnvironment.WebRootPath, "img");
                    fileName = $"{Guid.NewGuid().ToString()}_{model.ProfileImage.FileName}";
                    var path = Path.Combine(folder, fileName);
                    model.ProfileImage.CopyTo(new FileStream(path, FileMode.Create));
                    user.ProfilePicturePath = fileName;
                }

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    TempData["AccountUpdated"] = "Your account has been updated";

                    return RedirectToAction("Overview", "Account");
                }
            }

            ViewBag.Title = "Edit account";

            return View(model);
        }

        [Route("Account/Overview")]
        public async Task<IActionResult> Overview()
        {
            var user = await GetCurrentUserAsync();
            var model = new AccountOverviewVM()
            {
                ProfilePicturePath = user.ProfilePicturePath,
                Email = user.Email,
                Name = $"{user.FirstName} {user.LastName}"
            };
            var roles = await _userManager.GetRolesAsync(user);

            model.Role = roles[0];

            return View(model);
        }

        [HttpGet]
        [Route("Account/ConfirmDelete")]
        public IActionResult ConfirmDeleteCurrentUser()
        {
            return View("ConfirmDelete");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCurrentUser()
        {
            var user = await GetCurrentUserAsync();

            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                TempData["UserIsAdmin"] = "An admin account can not be deleted.";

                return RedirectToAction("Overview", "Account");
                ;
            }

            var result = await _userManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                TempData["UserNotDeleted"] = "User could not be deleted.";

                return RedirectToAction("Overview", "Account");
            }

            TempData["UserDeleted"] = "User has been deleted.";

            return RedirectToAction("Index", "Home");
        }

        private Task<ApplicationUser> GetCurrentUserAsync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
        }
    }
}
