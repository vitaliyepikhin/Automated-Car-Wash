using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class RatingStorage
    {
        private readonly Dictionary<int, Rating> _Ratings = new();

        public Rating Create(Rating rating)
        {

            _Ratings.Add(rating.RatingId, rating);
            return rating;

        }

        public Rating Read(int RatingId)
        {
            return _Ratings[RatingId];
        }

        public Rating Update(int RatingId, Rating newRating)
        {
            _Ratings[RatingId] = newRating;
            return _Ratings[RatingId];
        }

        public bool Delete(int RatingId)
        {
            return _Ratings.Remove(RatingId);
        }
    }
}