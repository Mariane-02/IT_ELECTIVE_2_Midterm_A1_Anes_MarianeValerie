using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    // GET: /  or  /Home/Index
    public IActionResult Index()
    {
        ViewData["Title"] = "Home";
        ViewData["Badge"] = "👋 Welcome to my Portfolio";
        ViewData["Greeting"] = "HELLO, I'M";
        ViewData["FullName"] = "Mariane Valerie Añes";
        ViewData["RoleTitle"] = "Information Technology Student";
        ViewData["Intro"] = "I am passionate about software development, web technologies, " +
                             "and creating user-friendly applications. I continuously improve " +
                             "my programming skills through academic projects and hands-on learning.";
        return View();
    }

    // GET: /Home/About
    public IActionResult About()
    {
        ViewData["Title"] = "About Me";
        ViewData["SectionHeading"] = "About Me";
        ViewData["AboutParagraphOne"] = "I am an Information Technology student at Lyceum of Alabang " +
            "with a passion for software development, web technologies, and continuous learning. " +
            "I enjoy building applications that are functional, user-friendly, and designed to solve real-world problems.";
        ViewData["AboutParagraphTwo"] = "Throughout my academic journey, I have gained experience in " +
            "programming, database management, and web development through various projects. I am committed " +
            "to improving my technical skills, embracing new technologies, and growing into a competent software " +
            "developer who can contribute to the ever-evolving IT industry.";
        return View();
    }

    // GET: /Home/Skills
    public IActionResult Skills()
    {
        ViewData["Title"] = "Skills";
        ViewData["SectionHeading"] = "Skills";
        ViewData["SkillCategories"] = new List<(string Icon, string Category, string Items)>
        {
            ("bi-code-square", "Languages", "Java, C++, C#, Python, VBA"),
            ("bi-globe2", "Web Tech", "HTML, CSS, Bootstrap, ASP.NET Core MVC"),
            ("bi-database", "Databases", "Microsoft Access"),
            ("bi-tools", "Tools", "Visual Studio, Git/GitHub, Cisco Packet Tracer, Blender")
        };
        return View();
    }

    // GET: /Home/Projects
    public IActionResult Projects()
    {
        ViewData["Title"] = "Projects";
        ViewData["SectionHeading"] = "Projects";
        ViewData["ProjectList"] = new List<(string Title, string Description, string[] Tags, string RepoUrl)>
        {
            ("Student Management System – Procedural Core",
                "A console application built using procedural programming principles to manage student records, calculate course grade averages, and monitor academic performance.",
                new[] { "C#" },
                "https://github.com/Mariane-02/BSIT31E1_PRELIM_H1-ANES_MARIANE.git"),

            ("File Ingestion Engine",
                "A flexible backend utility that uses the Strategy and Factory design patterns to simplify parsing multiple file formats, transforming character streams, and validating data schemas.",
                new[] { "C#" },
                "https://github.com/Mariane-02/-BSIT31E1_PRELIM_H2_Anes_Mariane-Valerie.git"),

            ("FizzBuzz Logic Evaluation",
                "A console application that showcases control flow design, nested conditional logic, and modulo-based calculations to generate sequential numeric outputs.",
                new[] { "C#" },
                "https://github.com/Mariane-02/BSIT31E1_PRELIM_A1_ANES_MARIANE.git"),

            ("Console Calculator Engine",
                "An interactive console application featuring a continuous input loop, type-conversion checks, error handling for mathematical edge cases, and conditional arithmetic logic.",
                new[] { "C#" },
                "https://github.com/Mariane-02/BSIT31E1_PRELIM_A2_ANES_MARIANE.git"),

            ("Http client starter",
                "A lightweight ASP.NET Core Web API setup that configures dependency injection, core service frameworks, HTTP request routing middleware, and secure controller endpoints.",
                new[] { "C#", "json" },
                "https://github.com/Mariane-02/IT_ELECTIVE_2_PRELIM_EXAM_ANES_MARIANEVALERIE.git"),

            ("Transport Polymorphism Challenge",
                "An object-oriented test harness that validates class inheritance hierarchies, multiple interface implementations, factory-based object creation, and polymorphic behavior across different domain entities at runtime.",
                new[] { "C#" },
                "https://github.com/Mariane-02/Mariane-02-BSIT_31E1_PRELIM_Q1_Anes_Mariane-Valerie.git"),
        };
        return View();
    }

    // GET: /Home/Contact
    public IActionResult Contact()
    {
        ViewData["Title"] = "Contact";
        ViewData["SectionHeading"] = "Contact Information";
        ViewData["Email"] = "anesmariane@gmail.com";
        ViewData["Mobile"] = "+63 963 842 1009";
        ViewData["GitHubHandle"] = "github.com/Mariane-02";
        ViewData["GitHubUrl"] = "https://github.com/Mariane-02";
        ViewData["LinkedInUrl"] = "#";
        ViewData["FacebookHandle"] = "facebook.com/mariane.anes.24";
        ViewData["FacebookUrl"] = "https://www.facebook.com/mariane.anes.24/";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
