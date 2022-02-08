using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        public int Resultaat { get; set; }

        [BindProperty(Name = "input")]
        public int InputBindProperty { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
        }
    }
}
