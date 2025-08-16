# 🎯 Portfolio Management System - ASP.NET Core MVC

> **Personal Portfolio Management System** - A comprehensive web application for freelancers and developers. Features a modern portfolio website and an admin panel to manage all content without coding knowledge.

## 📖 About This Project

A **complete portfolio solution** combining a professional website with a content management system:

### 🌐 **Frontend (Portfolio Website)**
- Modern, responsive design showcasing your work
- Projects, experience, and skills display
- Contact form for client inquiries
- Mobile and desktop optimized

### ⚙️ **Admin Panel (Content Management)** 
- Easy content management without coding
- Project, experience, and skill management
- Message inbox for client communication
- Task management with to-do lists
- Real-time statistics dashboard

**What Problem Does It Solve?** 
- ✅ No need to hire developers for portfolio updates
- ✅ Professional online presence for attracting clients
- ✅ Centralized professional information management
- ✅ Direct client communication through contact forms

## 🛠️ Technology Stack

### **Backend**
- **ASP.NET Core 9.0** - Cross-platform web framework
- **Entity Framework Core** - Database operations with type safety
- **SQL Server LocalDB** - Lightweight database for development
- **C# 12.0** - Modern programming language

### **Frontend**
- **Bootstrap 5** - Responsive CSS framework
- **jQuery** - JavaScript for dynamic interactions
- **Razor Pages** - Server-side templating
- **HTML5/CSS3** - Modern web standards

## 🚀 Quick Start (5 Minutes)

### **Prerequisites**
- .NET 9.0 SDK
- Visual Studio 2022 or VS Code

### **Installation**

1. **Clone and setup**
   ```bash
   git clone <your-repository-url>
   cd Portfolio_Project_2
   dotnet restore
   ```

2. **Create database**
   ```bash
   dotnet ef database update
   ```

3. **Run application**
   ```bash
   dotnet run
   ```

4. **Access**
   - Portfolio: `https://localhost:5001`
   - Admin Panel: `https://localhost:5001/Layout/Index`

## 🗄️ What Data It Manages

| **Content Type** | **Purpose** |
|------------------|-------------|
| **Personal Info** | Bio and professional summary |
| **Work Experience** | Job history and achievements |
| **Skills** | Technical abilities with levels |
| **Projects** | Portfolio showcases with images |
| **Messages** | Client inquiries and communication |
| **Tasks** | Personal organization and planning |

## 🔧 Key Features

### **Admin Panel**
- **Experience Management**: Add, edit, delete work history
- **Message System**: Read and manage client inquiries
- **Task Management**: Personal to-do lists and organization
- **Content Updates**: Real-time website content changes

### **Technical Highlights**
- **MVC Architecture**: Clean separation of concerns
- **View Components**: Reusable UI components
- **Entity Framework**: Type-safe database operations
- **Responsive Design**: Works on all devices
- **Security**: SQL injection prevention, input validation

## 🏗️ Project Structure

```
Portfolio_Project_2/
├── Controllers/           # MVC Controllers (business logic)
├── DAL/                  # Data Access Layer
│   ├── Context/          # Database context
│   └── Entities/         # Data models
├── Views/                # User interface templates
├── ViewComponents/       # Reusable UI components
├── wwwroot/             # Static files (CSS, JS, images)
└── Migrations/          # Database version control
```

## 🚦 API Endpoints

```http
# Experience Management
GET/POST /Experience/ExperienceList
GET/POST /Experience/CreateExperience
GET/POST /Experience/UpdateExperience/{id}

# Message Management
GET /Message/Inbox
GET /Message/MessageDetail/{id}

# Task Management
GET/POST /ToDoList/Index
GET/POST /ToDoList/CreateToDoList
GET/POST /ToDoList/UpdateToDoList/{id}
```

## 🎯 Perfect For

- **Freelancers** seeking professional online presence
- **Developers** wanting to showcase their projects
- **Creative Professionals** needing portfolio websites
- **Anyone** who wants easy content management without coding

## 🔮 Future Enhancements

- [ ] User authentication system
- [ ] Email integration for contact forms
- [ ] Image upload and management
- [ ] Multi-language support
- [ ] Analytics dashboard
- [ ] Mobile app API

## 📞 Contact

- **Developer**: [Your Name]
- **Email**: [your.email@example.com]
- **Repository**: [GitHub Repository URL]

---

⭐ **Give it a star if you find this project useful!**

**Last Updated**: December 2024 | **Version**: 1.0.0 | **Status**: Production Ready