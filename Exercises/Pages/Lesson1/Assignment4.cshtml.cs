using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment4 : PageModel
    {
        public string h1title { get; set; }
        public string h2title { get; set; }
        public string h3title { get; set; }
        public void OnGet([FromRoute] string category, [FromRoute] string subcategory, [FromRoute] string productid)
        {
            if (subcategory == "subcategory")
            {
                h1title = category;
                h2title = "geen subcategory";
                if (productid == "0")
                {
                    h3title = "geen productid";
                }
                else
                {
                    h3title = productid;
                }
            }
            else
            {
                h1title = category;
                h2title = subcategory;
                if (productid == "0")
                {
                    h3title = "geen productid";
                }
                else
                {
                    h3title = productid;
                }
            }

        }
    }
}
