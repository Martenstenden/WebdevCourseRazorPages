using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        public double Result { get; set; }

        public void OnGet()
        {

        }

        public void OnPostAdd([FromForm] double previousresult, double input)
        {
            Result = previousresult + input;
        }

        public void OnPostSub([FromForm] double previousresult, double input)
        {
            Result = previousresult - input;
        }

        public void OnPostMul([FromForm] double previousresult, double input)
        {
            Result = previousresult * input;
        }

        public void OnPostDiv([FromForm] double previousresult, double input)
        {
            Result = previousresult / input;
        }
    }
}
