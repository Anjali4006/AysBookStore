using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;


namespace AysBooks1.Models
{
    public class ProductVM
    {
        public Product Product { get; set; }    // Display all the product details

        public IEnumerable<SelectListItem> CategoryList { get; set; }   // install package "Microsoft.AspNetCore.Mvc.Rendering"

        public IEnumerable<SelectListItem> CoverTypeList { get; set; }

    }
}