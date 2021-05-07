using System.ComponentModel.DataAnnotations;

namespace Parduotuve.Models
{
    public class Review
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[1-5]$", ErrorMessage = "Score can only be a number 1-5.")]
        public int Score { get; set; }

        public string ItemReview { get; set; }

        [Required]
        public Item Item { get; set; }
    }
}
