using System.ComponentModel.DataAnnotations;

namespace Parduotuve.Dtos
{
    public class ItemCreateDto
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string ItemInfo { get; set; }
    }
}
