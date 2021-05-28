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
    }
}
