using Microsoft.EntityFrameworkCore;
using Parduotuve.Dtos;
using Parduotuve.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parduotuve.Data
{
    public class SqlShopRepo : IReviewRepository,IItemRepository
    {

        private readonly ShopContext _context;

        public SqlShopRepo(ShopContext context)
        {
            _context = context;
        }

        public void CreateReviewByItem(Review rvw)
        {

            if (rvw == null)
            {
                throw new ArgumentNullException(nameof(rvw));
            }

            _context.Add(rvw);
        }

        public IEnumerable<Item> GetAllItems(ItemFiltersDto filters)
        {

            var items = _context.Item.Include(i => i.Reviews).AsQueryable();

            if (filters.ScoreFrom.HasValue)
            {
                items = items.Where(i => i.Reviews.Average(r => r.Score) > filters.ScoreFrom.Value);
            }

            if (filters.ScoreTo.HasValue)
            {
                items = items.Where(i => i.Reviews.Average(r => r.Score) < filters.ScoreTo.Value);
            }

            if (filters.Name != null)
            {
                items = items.Where(i => i.Name == filters.Name);
            }

            return items.ToList();
        }

        public Review GetReviewById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
