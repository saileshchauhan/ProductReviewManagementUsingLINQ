using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagementUsingLINQ
{
 public class ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
        public ProductReview(int productId, int userId, double rating, string review, bool islike)
        {
            ProductID = productId;
            UserID = userId;
            Rating = rating;
            Review = review;
            IsLike = islike;
        }
    }
}

