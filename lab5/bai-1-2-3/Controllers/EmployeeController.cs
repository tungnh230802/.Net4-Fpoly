

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Employee page";
        List<EmployeeModel> emp = new List<EmployeeModel>()
        {
            new EmployeeModel() {
                Id = 1,
                Name = "fpolyHcm",
                Address = "391A Nam kỳ khởi ngĩa...",
                Phone = "029 0344 2345"
            },
                        new EmployeeModel() {
                Id = 2,
                Name = "fpolyHn",
                Address = "137 Nguyễn Thị Thập...",
                Phone = "029 0344 3452"
            },
                        new EmployeeModel() {
                Id = 3,
                Name = "fpolyDn",
                Address = "Toà nhà Fpoly polytechnic...",
                Phone = "029 0344 3523"
            },
        };
        ViewBag.employee = emp;
        return View();
    }
}