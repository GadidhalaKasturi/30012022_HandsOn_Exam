using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookRecomendationWebApp.Models
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class BookViewModel
    {


        [DisplayName("BookTitle")]
        [Required(ErrorMessage = "Book name should not be empty.")]
        [RegularExpression(@"^[A-Z\sa-z]+$", ErrorMessage = "Book name must have only english letters")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Book name should be between 10 and 20 characters")]
        public string BookName { get; set; }
        [DisplayName("Book Review")]
        [Required(ErrorMessage = "Group name should not be empty.")]
        [RegularExpression(@"^[A-Z\sa-z]+$", ErrorMessage = "Book Review must have only english letters")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Book Review should be between 10 and 20 characters")]
        public string BookReview { get; set; }
        public int BookRating { get; set; }
    }
}