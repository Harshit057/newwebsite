document.addEventListener('DOMContentLoaded', function () {
    const registrationForm = document.querySelector('#registration form');
    const otpSection = document.getElementById('otp-section');
    
    // Handle registration form submission
    registrationForm.addEventListener('submit', function (event) {
      event.preventDefault();
      
      const formData = new FormData(registrationForm);
      
      fetch('/Account/Register', {
        method: 'POST',
        body: new URLSearchParams(formData),
      })
      .then(response => response.json())
      .then(data => {
        if (data.success) {
          // Display the OTP section
          otpSection.style.display = 'block';
          alert(data.message);
        } else {
          alert('Registration failed. Please try again.');
        }
      })
      .catch(error => console.error('Error:', error));
    });
  
    // Handle OTP form submission
    const otpForm = document.querySelector('#otp-section form');
    otpForm.addEventListener('submit', function (event) {
      event.preventDefault();
  
      const formData = new FormData(otpForm);
  
      fetch('/Account/VerifyOtp', {
        method: 'POST',
        body: new URLSearchParams(formData),
      })
      .then(response => response.json())
      .then(data => {
        if (data.success) {
          alert('OTP verified successfully!');
          // Optionally, redirect to a different page after verification
        } else {
          alert(data.message);
        }
      })
      .catch(error => console.error('Error:', error));
    });
  });
  