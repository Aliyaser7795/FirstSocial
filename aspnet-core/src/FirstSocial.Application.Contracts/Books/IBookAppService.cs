using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FirstSocial.Books
{
    public interface IBookAppService : IApplicationService
    {

        Task<PagedResultDto<BookDto>> GetListAsync(GetBooksInput input);
        Task<BookDto> GetAsync(Guid id);


        Task<BookDto> GetCountAsync (Guid id);



    }
}
