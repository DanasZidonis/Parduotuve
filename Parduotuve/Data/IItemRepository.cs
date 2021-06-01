using Parduotuve.Dtos;
using Parduotuve.Models;
using System.Collections.Generic;

namespace Parduotuve.Data
{
    public interface IItemRepository
    {
        bool SaveChanges();
        IEnumerable<Item> GetAllItems(ItemFiltersDto filters);

    }
}
