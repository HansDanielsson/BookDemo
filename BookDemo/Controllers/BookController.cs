using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BookDemo.Controllers
{
  public class BookController : Controller
  {
    //
    // GET /Book
    public IActionResult Index()
    {
      return View();
    }
    //
    // GET: /Book/Welcome
    public IActionResult Welcome(string name, int numTimes = 1)
    {
      ViewData["BookName"] = "Book name " + name;
      ViewData["BookId"] =numTimes;
      return View();
    }
  }
}
