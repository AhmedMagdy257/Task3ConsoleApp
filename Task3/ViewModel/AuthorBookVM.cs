using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Context;

namespace Task3.ViewModel
{
    internal class AuthorBookVM
    {
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
    }
}
