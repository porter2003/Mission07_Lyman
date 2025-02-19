namespace Mission06_Lyman.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Navigation property
        public ICollection<Movie> Movies { get; set; }
    }

}
