using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IntroToEF.Data
{
    public class DataContext :DbContext
    {
        public DataContext() :base("name=DefaultConnection")
        {

        }

        public DbSet<MoviesEF> Movies { get; set;}

    }
}
