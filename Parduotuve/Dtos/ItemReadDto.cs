using Parduotuve.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parduotuve.Dtos
{
    public class ItemReadDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ItemInfo { get; set; }

        public List<ReviewUpdateDto> Reviews { get; set; }
    }
}
