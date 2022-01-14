
using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    // CÂU 2
    // [Route("")]
    [Route("Student")]
    [Route("Student/Index")]
    public string Index()
    {
        return "Index() Action Method of StudentController";
    }

    // CÂU 2
    [Route("Student/Details/{id='id_string'}")]
    [Route("Student/Details/{id?}")]
    public string Details(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            return "Details() Action Method of StudentController";

        }
        return "Details() Action Method of StudentController and " + id.ToString();
    }
}