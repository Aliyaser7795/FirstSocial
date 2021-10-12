
using AutoMapper;
using FirstSocial.Books;

namespace FirstSocial
{
    public class FirstSocialApplicationAutoMapperProfile : Profile
    {
        public FirstSocialApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();
            CreateMap<CreateBookDto, Book>();
        }
    }
}
