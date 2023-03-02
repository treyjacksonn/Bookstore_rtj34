using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_rtj34.Models.ViewModels
{
    //defines the info to be passed to the view through the Controller
    public class BooksViewModel
    {
        public IQueryable<Book>Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
