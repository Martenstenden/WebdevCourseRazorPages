using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Action { get; set; }
        [BindProperty(SupportsGet = true)]
        public int scoreHome { get; set; }
        [BindProperty(SupportsGet = true)]
        public int scoreAway { get; set; }
        
        
        public void OnGet()
        {
            if (Action == "inchome")
            {
                scoreHome++;
            }

            else if (Action == "incaway")
            {
                scoreAway++;
            }
            else if (Action == "dechome")
            {
                scoreHome--;
            }

            else if (Action == "decaway")
            {
                scoreAway--;
            }
            else if (Action == "reset")
            {
                scoreHome = 0;
                scoreAway = 0;
            }
        }
    }
}