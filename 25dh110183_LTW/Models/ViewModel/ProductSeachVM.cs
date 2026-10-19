using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace _25dh110183_LTW.Models.ViewModel
{
    public class ProductSeachVM
    {
        // tieu chi tim kiem
        public string SearchTerm { get; set; }
        // danh sach san pham tim kiem duoc
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string SortOrder { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 10;
        public PagedList.IPagedList<Product> Products { get; set; }
        //public List<Product> Products { get; set; }
    }
}