using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel
    {
        public IEnumerable<string> Suppliers { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind Website - Suppliers";
            Suppliers = new [] {
                "Dunder Miffli", "Staples" , "Office Max"
            };
        }
    }
}