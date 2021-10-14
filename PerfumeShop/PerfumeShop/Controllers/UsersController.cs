using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PerfumeShop.Entities;
using PerfumeShop.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeShop.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UsersController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var appUsers = await userManager.Users.ToListAsync();
            var users = (from u in appUsers
                         select new User()
                         {
                             Avatar = u.Avatar,
                             Email = u.Email,
                             Phone = u.PhoneNumber,
                             UserId = u.Id,
                             UserName = u.UserName,
                             Roles = string.Join(',', Task.Run(async () => await userManager.GetRolesAsync(u)).Result.ToArray())
                         });
            return View(users);
        }
    }
}
