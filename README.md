أكيد، هذا README كامل للمشروع الثاني في بلوك واحد وجاهز للنسخ:

```md
# Dynamic Portfolio Management System

A dynamic personal portfolio management web application built with ASP.NET Core MVC, C#, Entity Framework Core, SQL Server, and ASP.NET Identity.

The system includes a public portfolio website and a complete administration dashboard for managing personal information, projects, skills, education, experience, certificates, services, testimonials, clients, plans, and contact messages.

## Features

### Public Portfolio Website

- Personal profile and About section
- Positions and professional titles
- Education section
- Experience section
- Skills section
- Certificates section
- Services
- Testimonials
- Clients
- Plans and plan items
- Portfolio categories
- Portfolio projects
- Social media links
- Contact information
- Contact form

### Admin Dashboard

- Secure authentication using ASP.NET Identity
- Manage personal information
- Manage positions
- Manage social media links
- Manage section titles
- Manage services
- Manage testimonials
- Manage clients
- Manage plans and plan items
- Manage facts and statistics
- Manage education
- Manage experience
- Manage skills
- Manage certificates
- Manage portfolio categories
- Manage portfolio projects
- Manage contact information
- Manage contact messages
- Reply to contact messages
- Upload and manage images
- Activate and deactivate records
- Dynamic content management

## Technologies Used

### Backend

- C#
- ASP.NET Core MVC
- Entity Framework Core
- LINQ
- ASP.NET Identity
- Repository Pattern
- ViewModels
- Mapping Extensions

### Database

- SQL Server
- SQL Server Management Studio

### Frontend

- HTML
- CSS
- JavaScript
- Bootstrap
- Razor Views

### Development Tools

- Visual Studio
- Git
- GitHub

## Project Structure

The project follows an ASP.NET Core MVC architecture and includes:

- Admin Area
- Controllers
- Models
- ViewModels
- Repository Pattern
- Mapping Extensions
- Helpers
- Entity Framework Core DbContext
- ASP.NET Identity authentication and authorization
- Dynamic database-driven content management

## Database Setup

Configure the connection string in `appsettings.json`.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=PortfolioDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

Open Package Manager Console and create a migration:

```powershell
Add-Migration InitialCreate
```

Then update the database:

```powershell
Update-Database
```

## How to Run

Clone the repository:

```bash
git clone https://github.com/Bashir-Walid/Dynamic-Portfolio-Management-System.git
```

Then:

1. Open the solution in Visual Studio.
2. Configure the SQL Server connection string.
3. Apply Entity Framework Core migrations.
4. Run the project.

## What I Learned

Through this project, I gained practical experience with:

- Building dynamic web applications using ASP.NET Core MVC
- Connecting frontend templates with backend logic
- Designing and managing SQL Server databases
- Working with Entity Framework Core and LINQ
- Authentication and authorization using ASP.NET Identity
- CRUD operations
- Repository Pattern
- ViewModels
- Mapping data between Models and ViewModels
- File and image uploads
- Email integration
- Dynamic portfolio and content management
- Debugging database, validation, and nullability issues
- Building and managing a complete administration dashboard

## Training

This project was developed during practical ASP.NET Core MVC (.NET 8) training at Step by Step for Training & Consulting.

## Author

**Bashir Walid Ebdah**

- LinkedIn: https://www.linkedin.com/in/bashir-walid/
- GitHub: https://github.com/Bashir-Walid
```
