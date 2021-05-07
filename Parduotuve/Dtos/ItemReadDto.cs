using System.ComponentModel.DataAnnotations;

namespace Parduotuve.Dtos
{
    public class ItemReadDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ItemInfo { get; set; }
    }
}
