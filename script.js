// JavaScript to handle OTP section display
document.addEventListener('DOMContentLoaded', function () {
  // After successful registration, show OTP form
  const otpSection = document.getElementById('otp-section');
  const registrationForm = document.querySelector('#registration form');

  registrationForm.addEventListener('submit', function (event) {
      event.preventDefault();
      otpSection.style.display = 'block';
      alert("Registration successful! Please check your email or phone for the OTP.");
  });
});
