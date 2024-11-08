@{
    Layout = null;
}

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ProductAZ - Registration</title>
    <link rel="stylesheet" href="~/css/style.css">
</head>
<body>
    <header>
        <h1>ProductAZ</h1>
        <nav>
            <ul>
                <li><a href="/">Home</a></li>
                <li><a href="/About">About</a></li>
                <li><a href="/Products">Products</a></li>
                <li><a href="/Account/Login">Login</a></li>
            </ul>
        </nav>
    </header>

    <!-- Registration Form -->
    <section id="registration">
        <h2>Registration</h2>
        <form method="post" action="/Account/Register">
            <label for="username">Username:</label>
            <input type="text" id="username" name="username" placeholder="Enter username" required><br>

            <label for="name">Full Name:</label>
            <input type="text" id="name" name="name" placeholder="Enter your full name" required><br>

            <label for="address">Address:</label>
            <input type="text" id="address" name="address" placeholder="Enter your address" required><br>

            <label for="phone">Phone Number:</label>
            <input type="tel" id="phone" name="phone" placeholder="Enter phone number" required><br>

            <label for="email">Email:</label>
            <input type="email" id="email" name="email" placeholder="Enter email" required><br>

            <button type="submit">Register</button>
        </form>
    </section>

    <!-- OTP Section -->
    <section id="otp-section" style="display: none;">
        <h2>Enter OTP</h2>
        <form method="post" action="/Account/VerifyOtp">
            <label for="otp">One-Time Password (OTP):</label>
            <input type="text" id="otp" name="otp" placeholder="Enter the OTP you received" required><br>
            <button type="submit">Verify OTP</button>
        </form>
    </section>

    <footer>
        <p>Address: 123 Main St, Anytown, USA</p>
        <p>Email: productaz@gmail.com</p>
        <p>Phone: +1 123-456-7890</p>
    </footer>

    <script src="~/js/script.js"></script>
</body>
</html>
