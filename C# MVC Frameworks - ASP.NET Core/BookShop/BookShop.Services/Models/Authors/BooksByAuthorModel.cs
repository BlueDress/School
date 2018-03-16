using BookShop.Common.Mapping;
using BookShop.Data.Models;
using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;

namespace BookShop.Services.Models.Authors
{
    public class BooksByAuthorModel : IMapFrom<Book>, IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public decimal Price { get; set; }
        
        public int Copies { get; set; }

        public int AgeRestriction { get; set; }

        public int? Edition { get; set; }

        public DateTime ReleaseDate { get; set; }
        
        public string Author { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public void ConfigureCustomMapping(Profile profile)
        {
            profile.CreateMap<Book, BooksByAuthorModel>()
                .ForMember(b => b.Author, cfg => cfg.MapFrom(b => $"{b.Author.FirstName} {b.Author.LastName}"))
                .ForMember(b => b.Categories, cfg => cfg.MapFrom(b => b.Categories.Select(cb => cb.Category.Name)));
        }
    }
}
