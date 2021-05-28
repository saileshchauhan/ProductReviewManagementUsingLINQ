using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagementUsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC-1
            List<ProductReview> productReviews = new List<ProductReview>() 
            { new ProductReview(1,7,3,"Suggest Buy",true)};

            productReviews.Add(new ProductReview(2,  15, 1, "Defective", false));
            productReviews.Add(new ProductReview(5,  15, 4, "product is nice", true));
            productReviews.Add(new ProductReview(78, 23, 2, "Suitable", false));
            productReviews.Add(new ProductReview(2,  21, 5, "Good", false));
            productReviews.Add(new ProductReview(3,  16, 1, "Defective", false));
            productReviews.Add(new ProductReview(1, 19, 5, "nice product", false));
            productReviews.Add(new ProductReview(2,  17, 3, "Average", false));
            productReviews.Add(new ProductReview(101,15, 5, "Happy", false));
            productReviews.Add(new ProductReview(13, 56, 5, "Happy", false));
            productReviews.Add(new ProductReview(6,  107, 1, "Defective", false));
            productReviews.Add(new ProductReview(4,  14, 5, "Excellent", false));
            productReviews.Add(new ProductReview(6,  15, 1, "Defective", false));
            productReviews.Add(new ProductReview(17, 16, 5, "Excellent", false));
            productReviews.Add(new ProductReview(33, 14, 3, "Average", false));
            productReviews.Add(new ProductReview(13, 14, 7, "Excellent", false));
            productReviews.Add(new ProductReview(5,  55, 3, "Average", false));
            productReviews.Add(new ProductReview(10, 16, 1, "Defective", false));
            productReviews.Add(new ProductReview(10, 10, 6, "Excellent", true));
            productReviews.Add(new ProductReview(10, 56, 2, "Poor", false));
            productReviews.Add(new ProductReview(10, 11, 3, "Average", false));
            productReviews.Add(new ProductReview(10, 15, 5, "Good", false));
            //UC-1
            //UC-2
            try
            {
                ReviewManagement manage = new ReviewManagement();
                manage.TopThreeHighRatingProduct(productReviews);
                //UC-3
                Console.WriteLine("\n");
                manage.RatingGreaterThan_Three_ProductId(productReviews);
                //UC-4
                manage.CountOfReview_For_ProductId(productReviews);
                //UC-5
                manage.Retrieve_OnlyProductIdWithReview(productReviews);
                //UC-6
                manage.Skip_TopFiveRecords(productReviews);
                //UC - 7 SIMILAR TO UC - 5
                /*Implemented LINQ IN Data Table*/
                //UC - 8
                DataTableImplementation dataTable = new DataTableImplementation();
                dataTable.AddRecords_To_DataTabe(productReviews);
                ////UC-9
                dataTable.PrintRecords_With_IsLike_TrueFromDataTabe();
                //UC-10
                dataTable.AvearageRatingOfEachProductId();
                //UC - 11
                dataTable.AllRecords_ReviewContainsNice();
                //UC-12
                dataTable.AllRecords_OrderByRating_OfId10();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
