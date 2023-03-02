using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_rtj34.Models
{
    //Gets information from the database and puts it into the variable "Books"
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
