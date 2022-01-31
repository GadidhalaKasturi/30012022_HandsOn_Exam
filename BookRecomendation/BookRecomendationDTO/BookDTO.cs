using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecomendationDTO
{
    public class BookDTO
    {
        public int Book_isbn { get; set; }
        public string BookTitle { get; set; }
        public int BookEdition { get; set; }
        public int BookAuthorID { get; set; }
        public int BookRating { get; set; }
        public string BookReview { get; set; }
    }
}
