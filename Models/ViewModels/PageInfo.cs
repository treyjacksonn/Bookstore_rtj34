using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_rtj34.Models.ViewModels
{
    // Defines PageInfo, which is passed to the View through the BooksViewModel which goes through the Controller
    public class PageInfo
    {
        public int BookTotal { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int) Math.Ceiling((double) BookTotal/ BooksPerPage);
    }
}
