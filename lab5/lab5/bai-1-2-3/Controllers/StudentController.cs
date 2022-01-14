
using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    public ViewResult Index()
    {
        ViewData["Title"] = "Student Details Page";
        ViewData["Header"]  = "Student Details";
        StudentModel student = new StudentModel()
        {
            StudentId = 1,
            Name = "Fpoly",
            Branch = "HCM",
            Section = "Nam Ky Khoi Nghia"
        };
        ViewData["Student"] = student;
        return View();
    }
}