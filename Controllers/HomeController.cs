using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore_rtj34.Models;
using Bookstore_rtj34.Models.ViewModels;

namespace Bookstore_rtj34.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController(IBookstoreRepository br)
        {
            repo = br;
        }

        public IActionResult Index(string bookCat, int pageNum = 1)
        {
            int pageResults = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(b => b.Category == bookCat || bookCat == null)
               .OrderBy(b => b.Title)
               .Skip((pageNum - 1) * pageResults)
               .Take(pageResults),

                PageInfo = new PageInfo
                {
                    BookTotal = (bookCat == null
                    ? repo.Books.Count()
                    : repo.Books.Where(x => x.Category == bookCat).Count()),
                    BooksPerPage = pageResults,
                    CurrentPage = pageNum

                }
            };
           
            return View(x);
        }

        
    }
}
