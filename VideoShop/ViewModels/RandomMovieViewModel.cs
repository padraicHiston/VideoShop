using System.Collections.Generic;
using VideoShop.Models;

namespace VideoShop.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}