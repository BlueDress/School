using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewsSystem.Web.Models.ArticleViewModels
{
    public class ArticleEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(5000)]
        public string Content { get; set; }

        [Required]
        public string Category { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
