namespace Library.WebServices
{
    using System;
    using AutoMapper;
    using AutoMapper.Configuration;
    using Library.Domain;
    using Library.WebServices.ViewModels;

    internal class MapConfigurator
    {
        public IMapper CreateMapper()
        {
            return this.GetConfiguration().CreateMapper();
        }

        internal MapperConfiguration GetConfiguration()
        {
            var configuration = new MapperConfigurationExpression();
            this.CreateMaps(configuration);
            return new MapperConfiguration(configuration);
        }

        internal void CreateMaps(MapperConfigurationExpression expression)
        {
            expression.CreateMapFromAuthorToAuthorDto();
            expression.CreateMapFromAuthorToAuthorViewModel();
            expression.CreateMapFromBookToBookDto();
            expression.CreateMapFromBookToBookViewModel();
        }
    }

    internal static class MappingConfigurationExpressionExtension
        {
            public static void CreateMapFromAuthorToAuthorDto(this IProfileExpression expression)
            {
                expression.CreateMap<Author, AuthorDTO>()
                    .ForMember(
                        d => d.FirstName,
                        opt => opt.MapFrom(s => GetValueSafety(s.Name, n => n.FirstName)))
                    .ForMember(
                        d => d.MiddleName,
                        opt => opt.MapFrom(s => GetValueSafety(s.Name, n => n.MiddleName)))
                    .ForMember(
                        d => d.LastName,
                        opt => opt.MapFrom(s => GetValueSafety(s.Name, n => n.LastName)));
            }

        public static void CreateMapFromBookToBookDto(this IProfileExpression expression)
        {
            expression.CreateMap<Book, BookDTO>()
                .ForMember(d => d.Title, opt => opt.MapFrom(s => s.Title))
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(d => d.Shelf, opt => opt.MapFrom(src => src.Shelf));
        }

        private static TResult GetValueSafety<TInput, TResult>(TInput target, Func<TInput, TResult> getter)
        {
            return target is null || getter is null ? default : getter.Invoke(target);
        }

        public static void CreateMapFromAuthorToAuthorViewModel(this IProfileExpression expression)
        {
            expression.CreateMap<Author, AuthorViewModel>()
                .ForMember(
                    d => d.FullName,
                    opt => opt.MapFrom(s => s.Name.FullName));
        }

        public static void CreateMapFromBookToBookViewModel(this IProfileExpression expression)
        {
            expression.CreateMap<Book, BookViewModel>()
                .ForMember(
                    d => d.Title,
                    opt => opt.MapFrom(s => s.Title))
                .ForMember(
                d => d.Author,
                opt => opt.MapFrom(s => s.Authors));
        }
    }
}
