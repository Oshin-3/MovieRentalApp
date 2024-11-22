using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRentalApp.Models;

namespace MovieRentalApp.ViewModel
{
    public class RandomViewModel
    {
        public Movies Movies { get; set; }
        public List<Customers> Customers { get; set; }
    }
}