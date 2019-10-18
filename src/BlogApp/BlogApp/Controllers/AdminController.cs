using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AdminController : Controller
    {
        private const string AdminLayout = "AdminLayout";

        public IActionResult Index()
        {
            return View(nameof(Index), nameof(AdminLayout));
        }

        public IActionResult AllUsers()
        {
            return View(nameof(AllUsers), nameof(AdminLayout));
        }

        public IActionResult AllPosts()
        {
            return View(nameof(AllPosts), nameof(AdminLayout));
        }

        public IActionResult AllCategories()
        {
            return View(nameof(AllCategories), nameof(AdminLayout));
        }
    }
}