﻿using Parduotuve.Models;
using System.ComponentModel.DataAnnotations;

namespace Parduotuve.Dtos
{
    public class ReviewCreateDto2
    {
        [Required]
        [RegularExpression(@"^[1-5]$", ErrorMessage = "Score can only be a number 1-5.")]
        public int Score { get; set; }

        public string ItemReview { get; set; }

        [Required]
        public int ItemId { get; set; }
    }
}
