using Parduotuve.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parduotuve.Data
{
    public class SqlShopRepo : IShopRepo
    {

        private readonly ShopContext _context;

        public SqlShopRepo(ShopContext context)
        {
            _context = context;
        }

        public void CreateReviewByItem(string itemName, Review rvw)
        {
            if (itemName == null)
            {
                throw new ArgumentNullException(itemName);
            }

            if (rvw == null)
            {
                throw new ArgumentNullException(nameof(rvw));
            }

            rvw.Item = _context.Item.FirstOrDefault(p => p.Name == itemName);

            _context.Add(rvw);
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _context.Item.ToList();
        }

        public IEnumerable<Review> GetAllReviews()
        {
            return _context.Review.ToList();
        }

        public Item GetItemById(int id)
        {
            return _context.Item.FirstOrDefault(p => p.Id == id);
        }

        public Item GetItemByName(string name)
        {
            return _context.Item.FirstOrDefault(p => p.Name == name);
        }

        public IEnumerable<Item> GetItemsByBestReviews()
        {
            var sqlCommand = "SELECT i.name,i.ItemInfo, ROUND(AVG(CAST(r.Score AS FLOAT)),2) AS Score FROM Item i INNER JOIN Review r ON r.ItemId = i.Id GROUP BY i.Name,i.ItemInfo ORDER BY Score DESC";

            return _context.Item.Join(_context.Review.ToList(),
                item => item.Id,    // outerKeySelector
                      review => review.Item.Id,  // innerKeySelector
                      (item, review) => item).ToList();
        }

        public IEnumerable<Item> GetItemsByWorstReviews()
        {
            var sqlCommand = "SELECT i.name,i.ItemInfo, ROUND(AVG(CAST(r.Score AS FLOAT)),2) AS Score FROM Item i INNER JOIN Review r ON r.ItemId = i.Id GROUP BY i.Name,i.ItemInfo ORDER BY Score";

            return _context.Item.Join(_context.Review.ToList(),
                item => item.Id,    // outerKeySelector
                      review => review.Item.Id,  // innerKeySelector
                      (item, review) => item).ToList();
        }

        public IEnumerable<Review> GetReviewsByItem(string itemName)
        {
            return _context.Review.Where(p => p.Item.Name == itemName);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
