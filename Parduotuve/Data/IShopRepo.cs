using Parduotuve.Models;
using System.Collections.Generic;

namespace Parduotuve.Data
{
    public interface IShopRepo
    {
        bool SaveChanges();
        IEnumerable<Item> GetAllItems();
        Item GetItemByName(string name);
        IEnumerable<Item> GetItemsByWorstReviews();
        IEnumerable<Item> GetItemsByBestReviews();
        IEnumerable<Review> GetReviewsByItem(string itemName);
        void CreateReviewByItem(string itemName, Review rvw);

    }
}
