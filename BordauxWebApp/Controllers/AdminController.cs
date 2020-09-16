using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BordauxLib.Entities;
using BordauxWebApp.ViewModels;

namespace BordauxWebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _hostingEnvironment;

        public AdminController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IHostingEnvironment hostingEnvironment)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> AccountsOverview()
        {
            var model = new List<AdminAccountsOverviewVM>();

            foreach (var user in _userManager.Users)
            {
                var roles = await _userManager.GetRolesAsync(user);

                model.Add(new AdminAccountsOverviewVM()
                {
                    Id = user.Id,
                    Email = user.Email,
                    Name = $"{user.FirstName} {user.LastName}",
                    ProfilePicturePath = user.ProfilePicturePath,
                    Roles = roles
                });
            }

            ViewBag.Title = "Accounts overview";

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            ViewBag.Title = "Create user";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(AdminCreateUserVM model)
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
                    fileName = $"{Guid.NewGuid().ToString()}_{model.ProfileImage.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    model.ProfileImage.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                var account = new ApplicationUser { FirstName = model.FirstName, LastName = model.LastName, UserName = model.Email, Email = model.Email, ProfilePicturePath = fileName };
                var result = await _userManager.CreateAsync(account, model.Password);

                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(account.Email);
                    await _userManager.AddToRoleAsync(user, "User");
                    TempData["UserRegistered"] = $"User with Id {user.Id} has been created.";

                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            ViewBag.Title = "Create user";

            return View(model);
        }

        [HttpGet]
        [Route("Admin/UpdateUser/{id}")]
        public async Task<IActionResult> UpdateUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                TempData["UserDoesNotExist"] = $"An user with Id {id} does not exist.";

                return RedirectToAction("AccountsOverview", "Admin");
            }

            var rolesVM = new List<AdminUserRoleVM>();

            foreach (var role in _roleManager.Roles)
            {
                rolesVM.Add(new AdminUserRoleVM()
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    UserId = user.Id,
                    UserName = user.UserName,
                    IsChecked = await _userManager.IsInRoleAsync(user, role.Name)
                });
            }

            var model = new AdminUpdateUserVM()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                ProfilePicturePath = user.ProfilePicturePath,
                Roles = rolesVM
            };

            return View(model);
        }

        [HttpPost]
        [Route("Admin/UpdateUser/{id}")]
        public async Task<IActionResult> UpdateUser(AdminUpdateUserVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);
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

                foreach (var role in model.Roles)
                {
                    if (role.IsChecked)
                    {
                        await _userManager.AddToRoleAsync(user, role.RoleName);
                    }
                    else
                    {
                        await _userManager.RemoveFromRoleAsync(user, role.RoleName);
                    }
                }

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    TempData["UserUpdated"] = $"User {model.Email} has been updated.";

                    return RedirectToAction("AccountsOverview");
                }

                TempData["UserUpdated"] = $"User {model.Email} could not be updated.";

                return RedirectToAction("AccountsOverview");
            }

            ViewBag.Title = "Edit account";

            return View(model);
        }

        [HttpGet]
        [Route("Admin/ConfirmDeleteUser/{id}")]
        public async Task<IActionResult> ConfirmDeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewData["UserNotFound"] = $"User with id {id} does not exist.";

                return RedirectToAction("AccountsOverview", "Admin");
            }

            var model = new AdminAccountsOverviewVM()
            {
                Id = user.Id,
                Email = user.Email,
                Name = $"{user.FirstName} {user.LastName}",
                ProfilePicturePath = user.ProfilePicturePath,
                Roles = await _userManager.GetRolesAsync(user)
            };

            ViewBag.Title = "Delete user";

            return View(model);
        }

        [HttpPost]
        [Route("Admin/DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                TempData["UserNotFound"] = $"User with id {id} does not exist.";

                return RedirectToAction("AccountsOverview", "Admin");
            }

            var result = await _userManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                TempData["UserNotRemoved"] = "User could not be removed.";

                return RedirectToAction("AccountsOverview", "Admin");
            }

            TempData["UserRemoved"] = $"User with id {id} removed successfully.";

            return RedirectToAction("AccountsOverview", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> RolesOverview()
        {
            var model = new List<AdminRolesOverviewVM>();

            foreach (var role in _roleManager.Roles)
            {
                var users = await _userManager.GetUsersInRoleAsync(role.Name);

                model.Add(new AdminRolesOverviewVM()
                {
                    Id = role.Id,
                    Name = role.Name,
                    ApplicationUsers = users
                });
            }

            ViewBag.Title = "Roles overview";

            return View(model);
        }

        [HttpGet]
        [Route("Admin/CreateRole")]
        public IActionResult CreateRole()
        {
            ViewBag.Title = "Create role";

            return View();
        }

        [HttpPost]
        [Route("Admin/CreateRole")]
        public async Task<IActionResult> CreateRole(AdminCreateRoleVM model)
        {
            if (ModelState.IsValid)
            {
                if (await _roleManager.RoleExistsAsync(model.Name))
                {
                    ModelState.AddModelError("Name", "This role already exists.");
                }
                else
                {
                    var role = new IdentityRole(model.Name);
                    var result = await _roleManager.CreateAsync(role);

                    if (!result.Succeeded)
                    {
                        TempData.Add("RoleCreationFailed", $"Failed to create role {model.Name}.");
                    }
                    else
                    {
                        TempData.Add("RoleCreated", $"Role {model.Name} created.");
                    }
                }

                return RedirectToAction("RolesOverview", "Admin");
            }

            ViewBag.Title = "Create role";

            return View(model);
        }

        [HttpGet]
        [Route("Admin/UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            var users = _userManager.Users;
            var usersVM = new List<AdminUserRoleVM>();

            foreach (var user in users)
            {
                usersVM.Add(new AdminUserRoleVM()
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    UserId = user.Id,
                    UserName = user.UserName,
                    IsChecked = await _userManager.IsInRoleAsync(user, role.Name)
                });
            }

            var model = new AdminUpdateRoleVM()
            {
                Id = role.Id,
                Name = role.Name,
                ApplicationUsers = usersVM
            };

            ViewBag.Title = "Update role";

            return View(model);
        }

        [HttpPost]
        [Route("Admin/UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(AdminUpdateRoleVM model)
        {
            if (ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(model.Id);

                if (role == null)
                {
                    TempData["RoleNotFound"] = $"There is no role with Id {role.Id}";

                    return RedirectToAction("RolesOverview");
                }

                role.Name = model.Name;

                foreach (var user in model.ApplicationUsers)
                {
                    var u = await _userManager.FindByIdAsync(user.UserId);

                    if (user.IsChecked)
                    {
                        await _userManager.AddToRoleAsync(u, role.Name);
                    }
                    else
                    {
                        await _userManager.RemoveFromRoleAsync(u, role.Name);
                    }
                }

                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    TempData["RoleUpdated"] = $"Role {role.Name} has been updated.";

                    return RedirectToAction("RolesOverview");
                }

                TempData["RoleNotUpdated"] = $"Role {role.Name} could not be updated.";

                return RedirectToAction("RolesOverview");
            }

            ViewBag.Title = "Update role";

            return View(model);
        }

        [HttpGet]
        [Route("Admin/ConfirmDeleteRole/{id}")]
        public async Task<IActionResult> ConfirmDeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                TempData["RoleNotFound"] = $"Role with id {id} does not exist.";

                return RedirectToAction("RolesOverview");
            }

            var model = new AdminRolesOverviewVM()
            {
                Id = role.Id,
                Name = role.Name,
                ApplicationUsers = await _userManager.GetUsersInRoleAsync(role.Name)
            };

            ViewBag.Title = "Delete role";

            return View(model);
        }

        [HttpPost]
        [Route("Admin/DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                TempData["RoleNotFound"] = $"Role with id {id} does not exist.";

                return RedirectToAction("RolesOverview", "Admin");
            }

            var result = await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                TempData["RoleDeleted"] = $"Role {role.Name} has been deleted.";
                return RedirectToAction("RolesOverview", "Admin");
            }

            TempData["RoleNotDeleted"] = $"Role {role.Name} could not be removed.";

            return RedirectToAction("RolesOverview", "Admin");
        }
    }
}