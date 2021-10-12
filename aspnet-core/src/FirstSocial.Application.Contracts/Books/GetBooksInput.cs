
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace FirstSocial.Books
{
 public   class GetBooksInput : PagedAndSortedResultRequestDto
    {

        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public string BorrowBy { get; set; }

        public float Price { get; set; }
        public bool IsBorrowed { get; set; }
      
    }
}
