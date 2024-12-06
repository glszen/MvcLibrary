using Microsoft.AspNetCore.Mvc;
using MvcLibrary.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace MvcLibrary.Controllers
{
    public class LibraryController : Controller
    {

        public IActionResult LibraryIndex()
        {
            //To put books and authors on the same page.
            var authors = Data.Authors;  
            var books = Data.bookData;

            var viewModel = new LibraryViewModel
            {
                Author = authors,
                Book = books,

            };

            return View(viewModel);
        }

    }
}
