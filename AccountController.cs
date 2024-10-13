using Microsoft.AspNetCore.Mvc;

namespace ProductAZ.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Dummy login logic
            if (username == "admin" && password == "password")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password";
                return View();
            }
        }
    }
}
