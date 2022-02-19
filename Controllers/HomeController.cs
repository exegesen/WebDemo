using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

public class Home : Controller
{
    public IActionResult Index() 
    {
        return View("Index");
    
    }

    public IActionResult About()
    {
        return View("About");
    }

    public IActionResult Contact()
    {
        return View("Contact");
    }
    public IActionResult Projects()
    {
        return View("Projects");
    }
}