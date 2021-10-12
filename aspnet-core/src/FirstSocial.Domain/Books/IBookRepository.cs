
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FirstSocial.Books
{
   public interface IBookRepository : IRepository<Book, Guid>

    {
        Task<Book> GetListAsync(Guid id,bool IsBorrowed,string name, string borrowBy, float price, DateTime publishDate,DateTime BorrowEndDate);


      
        Task<List<Book>> GetAsync(bool IsBorrowed,
            string name,
            string borrowBy,
            float price,
            DateTime publishDate,
            DateTime BorrowEndDate,
             CancellationToken cancellationToken = default
            );


        Task<List<Book>> GetCountAsync(
           bool IsBorrowed,
            CancellationToken cancellationToken = default);
        
    }
}
