
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace FirstSocial.Books
{


    public class BookAppService : ApplicationService, IBookAppService
    {
        private readonly IBookRepository _BookRepository;

        public BookAppService(IBookRepository BookRepository)
        {

            _BookRepository = BookRepository;
           
        }


        public async Task<bool> RentAsync(Guid id)
        {
            // get the book by id
            var book = await _BookRepository.FindAsync(id);

            // validation
            // الكتاب موجود
            if (book == null)
                throw new UserFriendlyException("الكتاب غير موجود");
            // مدة الاستعارة لا تزيد عن 7
            // no action

            // لا يمكن استعارة كتاب مستعار
            if(book.IsBorrowed==true)
                throw new UserFriendlyException("الكتاب لايمكن الاستعارة");

            // rent the book to user
            book.IsBorrowed = true;
            book.BorrowStartDate = DateTime.Now;
            book.BorrowEndDate = DateTime.Now.AddDays(7);
            book.BorrowedBy = CurrentUser.Id.Value;

            // save
            await _BookRepository.UpdateAsync(book);

            //return
            return true;
        }

        public async Task<bool> ReturnBook(Guid id)

        {
            //validation 
            var book = await _BookRepository.FindAsync(id);
            //تحقيق الشروط
            if(book==null)
                throw new UserFriendlyException("الكتاب غير صحيح ");
            if (book.BorrowedBy != CurrentUser.Id.Value)
                throw new UserFriendlyException("المستعير  غير  صحيح ");

            //if (book!=null)
            //    throw new UserFriendlyException("الكتاب متوفر");
            ////
            //if (book.IsBorrowed == false)
            //    throw new UserFriendlyException("الكتاب يمكن استعارته");
          
            book.IsBorrowed = false;
            book.BorrowStartDate =null;
            book.BorrowEndDate = null;
            book.BorrowedBy = null;
            
            //
            await _BookRepository.UpdateAsync(book);

            return true;
        }


        public async Task EditPriceBook(Guid id,float price)

        {
          
            var book = await _BookRepository.FindAsync(id);

            if(book.IsBorrowed==true)
                throw new UserFriendlyException("الكتاب لايمكن الاستعارة");

            if (price>0)
                throw new UserFriendlyException("الكتاب السعر غير صحيح ");

            book.Price = price;
            //
            await _BookRepository.UpdateAsync(book);
            
        }


        public async Task<int> countbookIsBorrowed()
        {


            int count = _BookRepository.Where(x => x.IsBorrowed == true).Count();
            


            return count;

        }

        public Task<BookDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BookDto> GetCountAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<BookDto>> GetListAsync(GetBooksInput input)
        {
            throw new NotImplementedException();
        }
    }




}
