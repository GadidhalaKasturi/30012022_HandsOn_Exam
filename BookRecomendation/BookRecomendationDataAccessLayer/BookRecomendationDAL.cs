using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDTO;

namespace BookRecomendationDataAccessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class BookRecomendationDAL
    {

        SqlCommand cmdObj;
        SqlConnection conObj;


        public int FetchReviewsForBook(BookDTO newBookObj)
        {
            cmdObj = new SqlCommand();
            cmdObj.CommandText = @"uspAddReview";
           
            cmdObj.CommandType = System.Data.CommandType.StoredProcedure;
           
            cmdObj.Connection = conObj;
            cmdObj.Parameters.AddWithValue("@book_isbn", newBookObj.Book_isbn); 
            cmdObj.Parameters.AddWithValue("@rating", newBookObj.BookRating);
            cmdObj.Parameters.AddWithValue("@review", newBookObj.BookTitle);
            
            SqlParameter prmReturnValue = new SqlParameter();
            prmReturnValue.Direction = ParameterDirection.ReturnValue;
            prmReturnValue.SqlDbType = SqlDbType.Int;
            cmdObj.Parameters.Add(prmReturnValue);

            //Open C0nnection
            conObj.Open();
            cmdObj.ExecuteNonQuery();
            return Convert.ToInt32(prmReturnValue.Value);




        }

        public void SaveReviewForBookToDB()
        {
        }

}
}
