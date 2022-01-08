

using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    // CÂU 3C
    [Route("Home/Index/{id:int?}")]
    public string Index(int id)
    {
        return "I got " + id.ToString(); 
    }
}