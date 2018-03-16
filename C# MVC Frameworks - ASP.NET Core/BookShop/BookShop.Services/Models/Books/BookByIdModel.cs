using BookShop.Common.Mapping;
using BookShop.Data.Models;
using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;

namespace BookShop.Services.Models.Books
{
    public class BookByIdModel : IMapFrom<Book>, IHaveCustomMapping
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public decimal Price { get; set; }
        
        public int Copies { get; set; }

        public int AgeRestriction { get; set; }

        public int? Edition { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public void ConfigureCustomMapping(Profile profile)
        {
            profile.CreateMap<Book, BookByIdModel>()
                .ForMember(b => b.AuthorName, cfg => cfg.MapFrom(b => $"{b.Author.FirstName} {b.Author.LastName}"))
                .ForMember(b => b.Categories, cfg => cfg.MapFrom(b => b.Categories.Select(cb => cb.Category.Name)));
        }
    }
}
