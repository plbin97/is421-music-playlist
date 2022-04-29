using Microsoft.AspNetCore.Mvc;

namespace MusicList.Controllers
{
    public class UploadController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}