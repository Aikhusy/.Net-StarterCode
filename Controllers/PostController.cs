using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Startercode.Controllers;

public class PostController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index(string id, string names)
    {
        
        return "Http method Get : "+ id + " Names : " + names;
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }

   public IActionResult RenderView ()
   {
    return View("index");
   }
}