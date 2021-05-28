using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementUsingLINQ
{
    class ReviewManagement
    {
        //UC-1
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
        //UC-3
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
        //UC-4
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
        //UC-5
        public void Retrieve_OnlyProductIdWithReview(List<ProductReview> productReviews)
        {
            var recordData = (from record in productReviews
                              select record);
            foreach(var record in recordData)
            {
                Console.WriteLine("ProductId {0} Review {1} ",record.ProductID,record.Review);
            }
        }
        //UC-6
        public void Skip_TopFiveRecords(List<ProductReview> productReviews)
        {
            var recordData = (from record in productReviews
                              orderby record.Rating descending
                              select record).Skip(5);
            foreach(var record in recordData)
            {
                Console.WriteLine("ProductId {0} Rating {1} ",record.ProductID,record.Rating);
            }
        }

    }
}
