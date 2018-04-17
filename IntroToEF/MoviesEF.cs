using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF
{
    public class MoviesEF
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearReleased { get; set; }
        public string Genre { get; set; }
        public string Tagline { get; set; }
        public int Rating { get; set; }

    }
}
