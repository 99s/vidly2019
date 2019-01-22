using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly20119.Models;

namespace Vidly20119.ViewModels
{
    public class RandomMoviewViewModel
    {
        public Movie MovieVM { get; set; }
        public List<Customer> CustomerVM { get; set; }
    }
}