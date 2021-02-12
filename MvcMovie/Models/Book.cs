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
        public int id { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        [ForeignKey("Bookdetails_Id")]
        public Bookvalues Details { get; set; }

        public int DetailsId { get; set; }

        public BookAuthor AuthorInfo { get; set; }
    }
    public class Bookvalues
    {
        public int id { get; set; }
        public int No_chapter { get; set; }
        public int No_Pages { get; set; }
    }
    public class BookAuthor
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
    }
}
