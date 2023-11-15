
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Applications
{
    class library
    {
        public int LibraryId { get; set; }
        public string LibraryName { get; set; }
        public string Location { get; set; }
        public Book book { get; set; }
        public patron patrons { get; set; }

    }
}
