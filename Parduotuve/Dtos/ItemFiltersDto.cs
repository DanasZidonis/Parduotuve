using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parduotuve.Dtos
{
    public class ItemFiltersDto
    {
        public double? ScoreFrom { get; set; }
        public double? ScoreTo { get; set; }
        public string? Name { get; set; }
    }
}
