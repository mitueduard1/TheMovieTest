using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TheMovie.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
		    return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
		{
    		return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
		}
    }
}