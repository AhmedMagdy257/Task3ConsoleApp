using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Context;

namespace Task3.ViewModel
{
    internal class GetData
    {
        private readonly TaskDBContext context;
        public GetData(TaskDBContext _context) 
        {
            context = _context;


        }
        public async Task<AuthorBookVM> asynclist()
        {

            AuthorBookVM authorBookVM = new AuthorBookVM();
            authorBookVM.Books = await  BookAsync();
            authorBookVM.Authors =await  AuthorAsync();
            return authorBookVM;
        }
        public async Task<List<Author>> AuthorAsync()
        {
           return context.Authors.ToList();

        }

        public async Task<List<Book>> BookAsync()
        {
            return context.Books.ToList();
        }


    }
}
