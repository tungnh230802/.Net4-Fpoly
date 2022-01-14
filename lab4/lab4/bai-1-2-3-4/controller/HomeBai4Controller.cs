
// => Đây là HomeController của bải 4
using Microsoft.AspNetCore.Mvc;

public  class HomeBai4Controller : Controller
{
    // CÂU 4B
    // Constraint Attribute
    // [Route("HomeBai4/Index/{year:regex(^\\d{{4}}$)}")]
    public string Index(int year)
    {
        return "Year = " + year.ToString();
    }
}
