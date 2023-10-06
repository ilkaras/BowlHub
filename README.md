# BowlHub - Make your reservations

# Description
- The Bowling Reservation App offers a seamless and user-friendly experience for bowling enthusiasts. With our app, you can effortlessly secure your preferred bowling lane, ensuring that your bowling experience is both convenient and enjoyable. Say goodbye to long waits and hello to a stress-free bowling experience.

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

```bash
git clone https://github.com/your-username/your-repository-name.git
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
