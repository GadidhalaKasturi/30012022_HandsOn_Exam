using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BookRecomendationBusinessLayer;
using System.Collections.Generic;
using BookRecomendationDTO;
using BookRecomendationWebApp.Models;
using Newtonsoft.Json;

namespace BookRecomendationWebApp.Controllers
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class RecomendBookController : Controller
    {
        BookRecomendationBL blObj;

        public string BookTitle { get; private set; }
        public string BookReview { get; private set; }
        public int BookRating { get; private set; }

        public RecomendBookController()
        {
            blObj = new BookRecomendationBL();
        }
        // GET: RecomendBook
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult AddReviews(string Review)
        {
            try
            {
                List<BookDTO> lstOfDept = new List<BookDTO>();
                List<BookViewModel> lstOfbookModel = new List<BookViewModel>();
                foreach (var dept in lstOfDept)
                {
                    BookViewModel bookModelObj = new BookViewModel();
                    bookModelObj.BookRating = dept.BookRating;
                    bookModelObj.BookReview = dept.BookReview;
                    lstOfbookModel.Add(bookModelObj);
                }
                return View(lstOfbookModel);
            }
            catch (Exception ex)
            {

                return View("Error");
            }


        }

        public ActionResult DisplayResultsUsingWebAPI()
        {
            try
            {
                List<BookDTO> bookObj = new List<BookDTO>();
                List<BookViewModel> bookViewModels = new List<BookViewModel>();
                foreach (var review in bookObj)
                {
                    RecomendBookController recommand = new RecomendBookController();
                    recommand.BookTitle = review.BookTitle;
                    recommand.BookReview = review.BookTitle;
                    recommand.BookRating = review.BookRating;
                }
                return View(bookViewModels);
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
    }
}