using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//The bookstore repository

namespace Bookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
