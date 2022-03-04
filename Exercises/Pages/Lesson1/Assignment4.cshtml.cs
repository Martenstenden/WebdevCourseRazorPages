using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment4 : PageModel
    {
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string ProductId { get; set; }
        public void OnGet([FromRoute] string category,[FromRoute] string subcategory,[FromRoute] string productid)
        {
            Category = category;
            ProductId = productid;
            if (subcategory == "subcategory")
            {
                Category = category;
                ProductId = productid;
                SubCategory = "Geen Subcategorie";
                if (productid == "productid")
                {
                    ProductId = "Geen Product Id";
                }
                else
                {
                    ProductId = productid;
                }
            }
            else
            {
                Category = category;
                SubCategory = subcategory;
                if (productid == "productid")
                {
                    ProductId = "Geen Product Id";
                }
                else
                {
                    ProductId = productid;
                }
            }
            
        }
    }
}
