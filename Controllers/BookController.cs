using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using MvcLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MvcLibrary.Controllers
{
    public class BookController : Controller
    {

        public IActionResult BookIndex()
        {

            List<BookViewModel> books = Data.bookData.Select(b => new BookViewModel() //We put the books on the list.
            {
                Id = b.Id,
                Title = b.Title,
                Genre = b.Genre,
                authorName = Data.Authors.First(a => a.Id == b.AuthorId).AuthorName,
                PublishDate = b.PublishDate,
                ISBN = b.ISBN,
                CopiesAvailable = b.CopiesAvailable,
            }).ToList();

            return View(books);
        }


        public IActionResult BookList()
        {
            ViewBag.Authors = new SelectList(Data.Authors, "Id", "AuthorName");
            return View();
        }


        [HttpPost]
        public IActionResult BookList(BookViewModel book) //To add a book.
        {
            if (ModelState.IsValid)
            {

                Book book1 = new Book()
                {
                    Id = Data.bookData.Max(b => b.Id) + 1,
                    Title = book.Title,
                    Genre = book.Genre,
                    PublishDate = book.PublishDate,
                    AuthorId = book.AuthorId,
                    ISBN = book.ISBN,
                    CopiesAvailable = book.CopiesAvailable,
                };
                Data.bookData.Add(book1);
                TempData["Message"] = "Book added successfully.";
                return RedirectToAction("BookIndex");
            }
            ViewBag.Authors = new SelectList(Data.Authors, "Id", "AuthorName");
            return View();
        }

        public IActionResult Edit(int id) //To edit a book.
        {
            Book? book = Data.bookData.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return NotFound();

            EditViewModel vm = new EditViewModel()
            {
                Id = book.Id,
                Title = book.Title,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                AuthorId = book.AuthorId,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable,

            };
            ViewBag.Authors = new SelectList(Data.Authors, "Id", "AuthorName");
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel vm)
        {
            Book? book = Data.bookData.FirstOrDefault(b => b.Id == vm.Id);
            if (book == null) return NotFound();

            if(ModelState.IsValid)
            {
                book.Title = vm.Title;
                book.Genre = vm.Genre;
                book.PublishDate = vm.PublishDate;
                book.AuthorId = vm.AuthorId;
                book.ISBN = vm.ISBN;
                book.CopiesAvailable = vm.CopiesAvailable;

                TempData["Message"] = "Changes saved successfully.";
                return RedirectToAction("BookIndex");
            }
            ViewBag.Authors = new SelectList(Data.Authors, "Id", "AuthorName");
            return View(vm);
        }

        public IActionResult DeleteCheck(int id)
        {
            Book? book = Data.bookData.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            return View(book);
        }

        [HttpPost]
        public IActionResult Delete(int id) //To delete a book.
        {
            Book? book = Data.bookData.FirstOrDefault(b => b.Id == id);
              if (book == null) return NotFound();

            Data.bookData.Remove(book);
            TempData["Message"] = "Book deleted successfully.";
            return RedirectToAction("BookIndex");
        }

        public IActionResult BookDetail(int id)
        {
            Book? book = Data.bookData.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return NotFound();

            var author = Data.Authors.FirstOrDefault(a => a.Id == book.AuthorId);

            ViewBag.AuthorName = author?.AuthorName;

            ViewBag.AuthorLastName = author?.AuthorLastName;

            return View(book);
        }


    }
}

