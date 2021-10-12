
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace FirstSocial.Books
{
    public class BookDto : AuditedEntityDto<Guid>
    {

        public string Name { get; set; }

    
        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public Guid? BorrowBy { get; set; }

        
        public float Price { get; set; }

        [Display(Name = "Is Borrowed")]
        public bool IsBorrowed { get; set; }
        public DateTime BorrowStartDate { get; set; }

        public DateTime BorrowEndDate { get; set; }

    }
}