using System.ComponentModel.DataAnnotations;

namespace Mission06_Lyman.Models
{
    public class Movie
    {
        [Required ]
        public int MovieId{ get; set; }
        [Required (ErrorMessage = "Select a category.")]
        public int? CategoryId { get; set; }
        [Required (ErrorMessage = "Enter a title.")]
        public string? Title { get; set; }
        [Required (ErrorMessage = "Enter a year after 1888.")]
        [Range(1888, 2030)]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
            
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }

        public Category? Category { get; set; }
    }
}
