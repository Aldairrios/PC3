using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserManagementApp.Models;
using UserManagementApp.Services;

namespace UserManagementApp.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _userService.GetUsersAsync();
            return View(response.Data);
        }

        public async Task<IActionResult> Details(int id)
        {
            var response = await _userService.GetUserAsync(id);
            if (response.Data == null)
            {
                return NotFound();
            }
            return View(response.Data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUser user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            var response = await _userService.CreateUserAsync(user);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            ModelState.AddModelError(string.Empty, "Error creating user");
            return View(user);
        }
    }
}
