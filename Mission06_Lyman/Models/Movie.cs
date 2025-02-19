﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Lyman.Models
{
    public class Movie
    {
        [Required]
        public int MovieId{ get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public required string Title { get; set; }
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
