using ComicBookGalleryApp.Data;
using ComicBookGalleryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGalleryApp.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRespository = null;

        public ComicBooksController()
        {
            _comicBookRespository = new ComicBookRepository();
        }
        
        public ActionResult Index()
        {
            var comicBooks = _comicBookRespository.GetComicBooks();

            return View(comicBooks);
        }
        public ActionResult Detail (int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRespository.GetComicBook((int)id);
            
            return View(comicBook);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}
