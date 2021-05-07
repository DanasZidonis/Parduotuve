using System.ComponentModel.DataAnnotations;

namespace Parduotuve.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ItemInfo { get; set; }
    }
}
