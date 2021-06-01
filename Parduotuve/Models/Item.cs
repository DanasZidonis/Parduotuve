using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [InverseProperty("Item")]
        public ICollection<Review> Reviews { get; set; }
    }
}
