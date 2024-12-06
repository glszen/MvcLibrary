using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using MvcLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace MvcLibrary.Controllers
{
    public class AuthorControllers : Controller
    {

        public IActionResult AuthorIndex()
        {

            List<AuthorViewModel> authors = Data.Authors.Select(a => new AuthorViewModel() //We put the authors on the list
            {
                Id = a.Id,      
                AuthorName = a.AuthorName,
                AuthorLastName = a.AuthorLastName,
                DateOfBirth = a.DateOfBirth,

            }).ToList();

            return View(authors);
        }


        public IActionResult AuthorList()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AuthorList(AuthorViewModel author) //To add a author.
        {
            if (ModelState.IsValid)
            {
                Author author1= new Author()
                {
                    Id = Data.Authors.Max(a => a.Id) + 1,
                    AuthorName = author.AuthorName,
                    AuthorLastName= author.AuthorLastName,
                    DateOfBirth = author.DateOfBirth
                };
                Data.Authors.Add(author1);
                TempData["Message"] = "Author added successfully.";
                return RedirectToAction("AuthorIndex");
            }
            return View();
        }

        public IActionResult EditAuthor(int id) //To edit a author.
        {
            Author? author = Data.Authors.FirstOrDefault(a => a.Id == id);

            if (author == null)
                return NotFound();

            EditViewAuthorModel avm = new EditViewAuthorModel()
            {
                Id = author.Id,
                AuthorName = author.AuthorName,
                AuthorLastName = author.AuthorLastName,
                DateOfBirth = author.DateOfBirth,
            };
            return View(avm);
        }

        [HttpPost]
        public IActionResult EditAuthor(EditViewAuthorModel avm)
        {
            Author? author = Data.Authors.FirstOrDefault(a => a.Id == avm.Id);
            if (author == null) return NotFound();

            if (ModelState.IsValid)
            {
                author.AuthorName = avm.AuthorName;
                author.AuthorLastName = avm.AuthorLastName;
                author.DateOfBirth = avm.DateOfBirth;
                TempData["Message"] = "Changes saved successfully.";
                return RedirectToAction("AuthorIndex");

            }  
            return View(avm);
        }

        public IActionResult DeleteAuthorCheck(int id) //To delete a author.
        { 
            Author? author = Data.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();

            bool hasBooks = Data.bookData.Any(b => b.AuthorId == author.Id); 

            if (hasBooks) //If the author has a book, the author cannot be deleted
            {
                TempData["Alert"] = "This author has books, so the author cannot be deleted.";
                return RedirectToAction("AuthorIndex"); 
            }

            return View(author);
        }

        [HttpPost]
        public IActionResult DeleteAuthor(int id)
        {
            Author? author = Data.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            Data.Authors.Remove(author);
            TempData["Message"] = "Author deleted successfully.";
            return RedirectToAction("AuthorIndex");
        }

        

        public IActionResult AuthorDetail(int id)
        {
            Author? author = Data.Authors.FirstOrDefault(a => a.Id == id);

            if (author == null)
                return NotFound();

            return View(author);
        }
    }
}

