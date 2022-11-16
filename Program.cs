using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problems Using LINQ");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 4.5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 2, UserId = 10, Rating = 6, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 3, UserId = 2, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 4, UserId = 1, Rating = 5, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 5, UserId = 3, Rating = 5, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 6, UserId = 4, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 7, UserId = 10, Rating = 7.5, Review = "Good", isLike=false},
            new ProductReview() { ProductId = 4, UserId = 10, Rating = 1.5, Review = "Good", isLike=false },
            new ProductReview() { ProductId = 9, UserId = 3, Rating = 6.5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 10, UserId = 2, Rating = 5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 11, UserId = 10, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 12, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 13, UserId = 5, Rating = 5, Review = "Bad", isLike=true },
            new ProductReview() { ProductId = 14, UserId = 10, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 15, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 24, UserId = 24, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 25, UserId = 25, Rating = 5, Review = "Good", isLike=true }
            };
            //UC1
            Console.WriteLine("\nRows in the table = ");

            foreach (var list in productReviewList)
            {
                Console.WriteLine("Product id = " + list.ProductId + "User id = " + list.UserId + "Rating is = " + list.Rating + " Review is = " + list.Review + " isLike = " + list.isLike);
            }
            Management management = new Management();
            // UC2 Retrieve Top 3 records from list.
            management.TopRecords(productReviewList);

            //UC3 Selects the record with rating grater than 3 and with product id = 1,4,9.
            management.selectedRecords(productReviewList);

            //UC4 Retrieves the count of record with  the help of group by id.
            management.RetrieveCountOfRecords(productReviewList);

            // UC5
            management.RetrieveProductIdAndReview(productReviewList);

            // UC6
            management.SkipTopFiveRecords(productReviewList);

            //UC7
            management.RetrieveProductIdAndReviews(productReviewList);

            // UC8
            DataTable dataTable = management.CreateTable(productReviewList);
            foreach (var list in productReviewList)
            {
                dataTable.Rows.Add(list.ProductId, list.UserId, list.Rating, list.Review, list.isLike);
            }

            // UC9
            management.RetrieveRecordsWithIsLikeValueTrue(dataTable);

            // UC10
            management.FindAvrageRating(productReviewList);

            // UC11
            management.RecordsWithNiceReview(productReviewList);

            // UC12
            management.GetRecordsForUserIdTen(productReviewList);
        
        }
    }
}
