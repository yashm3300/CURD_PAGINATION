using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace pagination.model
{
    public class Categorymodel
    {
        internal int CurrentIndex;

        public List<Category> list { get; set; }
        public int CategoryID { get; set; }
        public int PageCount { get; set; }
    }
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int Department { get; set; }
    }
}