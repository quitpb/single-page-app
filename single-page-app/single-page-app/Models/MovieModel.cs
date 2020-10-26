using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace single_page_app.Models
{
    public class MovieModel
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public DateTime Date { get; set; }

        public string Cast { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int MyProperty { get; set; }

    }
}
