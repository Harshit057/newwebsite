using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System;

namespace ProductAZ.Controllers
{
    public class AccountController : Controller
    {
        private static string generatedOtp;
        private static string registeredEmail;
        private static string registeredPhone;

        [HttpPost]
        public IActionResult Register(string username, string name, string address, string phone, string email)
        {
            // Store user details
            registeredEmail = email;
            registeredPhone = phone;

            // Generate OTP
            generatedOtp = GenerateOtp();
            
            // Send OTP via Email (or Phone)
            SendOtpEmail(email, generatedOtp);
            
            // Redirect to OTP page
            return View("Otp");
        }

        [HttpPost]
        public IActionResult VerifyOtp(string otp)
        {
            if (otp == generatedOtp)
            {
                return Content("OTP verified successfully! Registration complete.");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid OTP. Please try again.";
                return View("Otp");
            }
        }

        private string GenerateOtp()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendOtpEmail(string email, string otp)
        {
            string fromAddress = "your-email@gmail.com"; // Replace with your email
            string fromPassword = "your-email-password"; // Replace with your email password
            string subject = "Your OTP for ProductAZ";
            string body = $"Your OTP is: {otp}";

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromAddress, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(fromAddress, email, subject, body);
        }
    }
}
q