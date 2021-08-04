using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_New.Models;

namespace Vidly_New.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie movie { get; set; }
        public IEnumerable<Genre> genre { get; set; }
        public string Title
        {
            get
            {
                if (movie != null && movie.Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }
    }
}