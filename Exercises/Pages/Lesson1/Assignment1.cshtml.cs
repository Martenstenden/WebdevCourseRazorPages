using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        [BindProperty(SupportsGet = true)]

        public int scoreHome { get; set; }
        public int scoreAway { get; set; }
        public void OnGet([FromRoute] string action)
        {

            if (action == "incrementHome") { scoreHome++; }
            else if (action == "decrementHome") { scoreHome--; }
            else if (action == "incrementAway") { scoreAway++; }
            else if (action == "decrementAway") { scoreAway--; }
            else if (action == "reset") { scoreAway = 0; scoreAway = 0; }
        }
    }
}
