using Domain.Entities;

namespace Models.Out
{
    public class MovieDetailInfoModel
    {
        public MovieDetailInfoModel(Movie movie) {
            this.Id = movie.Id;
            this.Name = movie.Name;
            this.Description = movie.Description;
            this.AgeAllowed = movie.AgeAllowed;
            this.Category = new CategoryBasicInfoModel(movie.Category);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AgeAllowed { get; set; }
        public CategoryBasicInfoModel Category { get; set; }
    }
}