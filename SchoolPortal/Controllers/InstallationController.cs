using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Controllers
{
    public class InstallationController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public InstallationController(
            SignInManager<ApplicationUser> signInManager, 
            RoleManager<IdentityRole> roleManager, 
            UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
