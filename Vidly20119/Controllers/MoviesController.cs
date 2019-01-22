using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly20119.Models;
using Vidly20119.ViewModels;

namespace Vidly20119.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var _movie = new Movie() { Name = "Shrek!" };
            var _customers = new List<Customer>
            {
                new Customer{ Name = "C1"},
                new Customer{ Name = "C2"}
            };
            var viewM = new RandomMoviewViewModel
            {
                MovieVM = _movie,
                CustomerVM = _customers
            };
            return View(viewM);
        }

        //public ViewResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    return View(movie);
        //}
        public ActionResult Edit(int id)
        {
            return Content("id=" + id.ToString());
        }

        public ActionResult Index(int? _pageIndex, string _sortBy)
        {
            if(!_pageIndex.HasValue)
            {
                _pageIndex = 1;
            }
            if(string.IsNullOrWhiteSpace(_sortBy))
            {
                _sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortby={1}",_pageIndex,_sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/"+month);
        }
    }
}