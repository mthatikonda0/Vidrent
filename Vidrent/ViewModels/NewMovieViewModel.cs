using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidrent.Models;

namespace Vidrent.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }    
    }
}