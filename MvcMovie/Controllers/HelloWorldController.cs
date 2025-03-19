using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public ViewResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public ViewResult Welcome(string name, int NumTimes=1)
    {
        //return "This is the Welcome action method... from SundarRajan";
       // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
       ViewData["Message"] = "Hello"+name;
       ViewData["NumTimes"] = NumTimes;
       return View();
    }
}