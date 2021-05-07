using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Models provide the C sharp definition of your Database tables
// For each Table Column, we can define the data type and whether they are NULLABLE

namespace my_books.Data.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsRead { get; set; }

        public DateTime? DateRead { get; set; }

        public int? Rate { get; set; }

        public string Genre { get; set; }

        public string Author { get; set; }

        public string CoverURL { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
