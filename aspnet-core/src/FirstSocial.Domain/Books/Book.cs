using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace FirstSocial.Books
{


    public class Book : AuditedAggregateRoot<Guid>
    {
        
        public string Name { get; set; }
        

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public Guid? BorrowedBy { get; set; }

        
        public float? Price { get; set; }
        public bool IsBorrowed { get; set; }
        public DateTime? BorrowStartDate { get; set; }

        public DateTime? BorrowEndDate { get; set; }







    }


}
