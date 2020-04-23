using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.ViewModel
{
    public class SearchViewModel
    {
        public string SearchText { get; set; }
        public bool SearchInDescription { get; set; }
        public int? CategoryId { get; set; }
    }
}
