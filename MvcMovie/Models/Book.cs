using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Book
    {
        public int Bid { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }

    }
}
