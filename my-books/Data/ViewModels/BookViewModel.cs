﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// View Model contains that part of the data that will be operated upon by the end user
// View Model definition(s) come up in the Swagger UI 

namespace my_books.Data.ViewModels
{
    public class BookViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsRead { get; set; }

        public DateTime? DateRead { get; set; }

        public int? Rate { get; set; }

        public string Genre { get; set; }

        public string Author { get; set; }

        public string CoverURL { get; set; }
    }
}
