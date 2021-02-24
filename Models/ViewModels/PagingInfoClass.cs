using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreApp.Models.ViewModels
{
    public class PagingInfoClass
        //creates the nav for pagination
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

       //get total pages
        public int TotalPages => (int) (Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
