using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_UnitTest
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> FindAll()
        {
            return null;
        }
    }

    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }

    public class Book
    {
        public string Title
        { get; set; }
    }
}

