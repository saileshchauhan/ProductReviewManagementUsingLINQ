using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementUsingLINQ
{
    class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopThreeHighRatingProduct(List<ProductReview> productReviews)
        {
            var recordData = (from review in productReviews
                             orderby review.Rating descending
                             select review).Take(3);
            foreach (var revew in recordData)
            {
                Console.WriteLine("ProductId {0} UserId {1} Rating {2} Review {3} IsLike {4} ",revew.ProductID,revew.UserID,revew.Rating,revew.Review,revew.IsLike);
            } 
        }
    }
}
