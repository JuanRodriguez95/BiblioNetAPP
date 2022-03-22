using BiblioNetAPP.Models;
using BiblioNetAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController : Controller
    {

        private readonly IRepositoryBook repositoryBook;

        public BookController(IRepositoryBook repositoryBook)
        {
            this.repositoryBook = repositoryBook;
        }

        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if(!ModelState.IsValid)
            {
                return View(book);
            }
            repositoryBook.Create(book);
            return View();
        }

       
    }
}
