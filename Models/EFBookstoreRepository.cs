using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_rtj34.Models
{
    //Inhertis from the IBookstoreRepository, allows for the the database information to be passed throughout the application
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository(BookstoreContext bsc) => context = bsc;

        public IQueryable<Book> Books => context.Books;
    }
}
