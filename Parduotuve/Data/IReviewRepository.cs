using Parduotuve.Dtos;
using Parduotuve.Models;
using System.Collections.Generic;

namespace Parduotuve.Data
{
    public interface IReviewRepository
    {
        bool SaveChanges();
        void CreateReviewByItem(Review rvw);
        Review GetReviewById(int id);

    }
}
