# BowlHub - Make your reservations

# Description
- The Bowling Reservation App offers a seamless and user-friendly experience for bowling enthusiasts. With our app, you can effortlessly secure your preferred bowling lane, ensuring that your bowling experience is both convenient and enjoyable. Say goodbye to long waits and hello to a stress-free bowling experience.

## Main page
### Embrace the Elegance & Simplicity
- Welcome to a digital space where every interaction is a step into a universe of possibilities. Dive into BowlHub, where we meticulously craft each pixel to amplify your digital experiences and adventures.
### Right Block: 
- Engage & Connect Returning users, welcome back! Click Log In to continue your journey with personalized experiences. New to our world? Click Sign In and join us or use Select the place to navigating through endless digital horizons.

![First page](https://github.com/ilkaras/BowlHub/assets/115924633/6243a2cc-eab5-4333-b2f0-36581eae070b)

## Log in 
- Here on our login page, we ensure a seamless re-entry into a world where your personal adventures and dynamic digital experiences await to be rejoined.Safe, Simple, Secure Your digital safety and ease of access are our prime directives. 
- Enter your credentials in a secure environment, designed with both simplicity and security in mind. Reservation space is just a few keystrokes away.

![Login page](https://github.com/ilkaras/BowlHub/assets/115924633/d53e59b4-e4da-476a-b0b5-c280e75aa9e9)

## Place page
- Closing Note Explore, immerse, and reserve with unmatched ease on BowlHub. Our platform is not merely a tool but a companion that understands your bowl curiosities and guides you to experiences that promise to satiate them splendidly.

![Select place](https://github.com/ilkaras/BowlHub/assets/115924633/6518fbc0-5517-4e9b-9cbb-28172d275642)

## Reservation
- Smooth Sailing to Your ReservationEmbark on an exceptionally user-friendly reservation journey with BowlHub. We’ve sculpted an interface where convenience and simplicity guide you from selection to confirmation in a few smooth steps, ensuring your pathway to delightful experiences is direct and delightful.

![Reservation](https://github.com/ilkaras/BowlHub/assets/115924633/4e250dd1-f793-4791-9108-3388eb122950)

## Reservation & payment
- Secure & Swift PaymentsAt the heart of our reservation process is a secure and speedy payment system. Employing cutting-edge security protocols, your transaction is not just a payment; it’s a safeguarded pass to your upcoming adventures in taste and experience. Utilize your card to confirm your reservation instantly, and step closer to a world where delightful experiences are ensured and exciting stories await creation.

![Reservation pay](https://github.com/ilkaras/BowlHub/assets/115924633/bae2bd73-5890-4047-b358-f73b01d09392)


# Features
- Real-time lane reservations
- Management of personal bookings
- Viewing schedules and available lanes
- Easy payment system
- Comfortable application
- Notification sendings

# Installation
- Describe how users or developers can install and run your application.

# Requirements
- .NET 6.0
- PostgeSQL

# Prerequisites
Ensure that you have installed:
- .NET SDK 6
- PostgreSQL
- Git
  
# Your Bowling Application Name

Description of your bowling application, its features, and purpose.

## Prerequisites

Ensure you have the following installed on your system:
- [.NET SDK 6](https://dotnet.microsoft.com/download/dotnet/6.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Git](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git)

## Installation Steps

### 1. Clone the Repository

bash
```
git clone https://github.com/your-username/your-repository-name.git
```
```
cd your-repository-name
```
### 2. Database Setup
- Create a new database and user in PostgreSQL.
- Update the connection string in appsettings.json:
```
"ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=your_database_name;Username=your_username;Password=your_password"
}
```
### 3. Dependency Installation and Database Migration
```
dotnet restore
```
```
dotnet ef database update
```
### 4. Run the Application
```
dotnet run
```
Navigate to http://localhost:5000 or https://localhost:5001 in your web browser.

## Issues
If you encounter any issues during installation or have questions, please create a new issue in the project repository.

## Support and Contribution
If you'd like to contribute to the project or need support, provide information on how to get in touch or how to participate in development.
