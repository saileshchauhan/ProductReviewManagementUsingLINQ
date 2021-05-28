using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementUsingLINQ
{
    class ReviewManagement
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
        public void RatingGreaterThan_Three_ProductId(List<ProductReview> productReviews)
        {
            var recordData = (from review in productReviews
                              where (review.ProductID == 1 && review.Rating > 3) || (review.ProductID == 4 && review.Rating > 3) ||
                              (review.ProductID == 9 && review.Rating > 3)
                              select review
                            );
            foreach (var revew in recordData)
            {
                Console.WriteLine("ProductId {0} UserId {1} Rating {2} Review {3} IsLike {4} ", revew.ProductID, revew.UserID, revew.Rating, revew.Review, revew.IsLike);
            }
        }
        public void CountOfReview_For_ProductId(List<ProductReview> productReviews)
        {
            var recordData = (from record in productReviews
                              group record by record.ProductID into grouP
                              select new { PersonID = grouP.Key, reviewCount = grouP.Count() });
               foreach(var record in recordData)
               {
                Console.WriteLine(" ProductId {0} Review {1} ",record.PersonID,record.reviewCount);
               }
        }

    }
}
