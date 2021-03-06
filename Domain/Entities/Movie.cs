using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [DefaultValue(0)]
        public int AgeAllowed { get; set; }

        public virtual List<CategoryMovie> CategoriesMovies { get; set; }
  }

}