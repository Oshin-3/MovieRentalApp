using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalApp.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int NoOfItems { get; set; }
        public Genres Genres { get; set; }


    }
}