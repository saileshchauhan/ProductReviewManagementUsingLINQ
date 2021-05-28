using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProductReviewManagementUsingLINQ
{
    class DataTableImplementation
    {
        DataTable table = new DataTable();
        //UC-8
        public void AddRecords_To_DataTabe(List<ProductReview> productReviews)
        {
            table.Columns.Add("Product Id", typeof(int));
            table.Columns.Add("User Id", typeof(int));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));
            foreach (var records in productReviews)
            {
                table.Rows.Add(records.ProductID, records.UserID, records.Rating, records.Review, records.IsLike);
            }
        }
        //UC-9
        public void PrintRecords_With_IsLike_TrueFromDataTabe()
        {
            var dataRecord = from record in table.AsEnumerable()
                             where record.Field<bool>("IsLike") == true
                             select new
                             {
                                 product = record.Field<int>("Product Id")
                             };
            foreach (var productid in dataRecord)
            {
                Console.WriteLine(productid);
            }
        }
        //UC-11
        public void AllRecords_ReviewContainsNice()
        {
            var dataRecord = from record in table.AsEnumerable()
                             where record.Field<string>("Review").Contains("nice")
                             select new
                             {
                                 product = record.Field<int>("Product Id")
                             };
            foreach (var productid in dataRecord)
            {
                Console.WriteLine(productid);
            }
        }

    }
}
