using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ProductAZ.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public async Task<IActionResult> Register(string username, string name, string address, string phone, string email)
        {
            // Save user data to the database (this part is simplified)
            // Simulate sending OTP via email or SMS here
            string otp = "123456"; // In real scenarios, generate and send a dynamic OTP

            // Store the OTP in session to verify later
            HttpContext.Session.SetString("otp", otp);

            // Return success message and enable OTP section on the front-end
            return Json(new { success = true, message = "Registration successful. OTP sent." });
        }

        // POST: /Account/VerifyOtp
        [HttpPost]
        public IActionResult VerifyOtp(string otp)
        {
            // Retrieve OTP from session
            var expectedOtp = HttpContext.Session.GetString("otp");

            if (otp == expectedOtp)
            {
                // OTP matches, complete registration
                return Json(new { success = true, message = "OTP verified successfully!" });
            }
            else
            {
                // OTP does not match
                return Json(new { success = false, message = "Invalid OTP. Please try again." });
            }
        }
    }
}
