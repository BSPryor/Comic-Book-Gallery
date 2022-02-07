using Microsoft.AspNetCore.Mvc;

namespace ComicBookGalleryApp.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail ()
        {
           return View();
        }
    }
}
